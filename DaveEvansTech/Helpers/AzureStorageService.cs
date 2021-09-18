using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DaveEvansTech.Contracts;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace DaveEvansTech.Helpers
{
    public class AzureStorageService : IFileStorageService
    {
        private readonly string _storageAccessKey;
        
        public string BaseUrl { get; }

        public AzureStorageService(IConfiguration configuration)
        {
            _storageAccessKey = configuration["AzureStorageAccessKey"];
            BaseUrl = configuration["BlobStorageBaseUrl"];
        }

        public async Task DeleteFile(string fileName, string containerName)
        {
            try
            {
                if (fileName != null)
                {
                    // Create a BlobServiceClient object which will be used to create a container client
                    BlobServiceClient blobServiceClient = new BlobServiceClient(_storageAccessKey);

                    // Create the container and return a container client object
                    BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);

                    if (!containerClient.Exists()) return;

                    BlobClient blobClient = containerClient.GetBlobClient(fileName);
                    await blobClient.DeleteIfExistsAsync();
                }
            }
            catch (Exception ex)
            {
                // TODO log exception
            }
          
        }

        

        public async Task<string> EditFile(byte[] content, string extension, string containerName, string fileRoute, string contentType)
        {
            await DeleteFile(fileRoute, containerName);
            return await SaveFile(content, extension, containerName, contentType);
        }

        public async Task<string> SaveFile(byte[] content, string extension, string containerName, string contentType, string fileName=null)
        {
            try
            {
                // Create a BlobServiceClient object which will be used to create a container client
                BlobServiceClient blobServiceClient = new BlobServiceClient(_storageAccessKey);

                // Create the container and return a container client object
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);             

                await containerClient.CreateIfNotExistsAsync();
                await containerClient.SetAccessPolicyAsync(PublicAccessType.Blob);

                fileName ??= $"{Guid.NewGuid()}{extension}";

                // Convert byte array to stream
                MemoryStream stream = new MemoryStream();
                stream.Write(content, 0, content.Length);

                await containerClient.UploadBlobAsync(fileName, stream);
                return containerClient.Uri.ToString();               
            }
            catch(Exception ex)
            {
                // TODO log exception
            }

            return null;
            
        }

        public string GetUri(string fileName, string containerName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName)) return null;

                // Create a BlobServiceClient object which will be used to create a container client
                BlobServiceClient blobServiceClient = new BlobServiceClient(_storageAccessKey);

                // Create the container and return a container client object
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);

                if (!containerClient.Exists()) return "";

                BlobClient blobClient = containerClient.GetBlobClient(fileName);
                return blobClient.Exists() ? blobClient.Uri.ToString() : "";
            }
            catch (Exception ex)
            {
                // TODO log exception
                return string.Empty;
            }
        }

        public async Task<byte[]> DownloadAsync(string fileName, string containerName)
        {
            try
            {

                // Create a BlobServiceClient object which will be used to create a container client
                BlobServiceClient blobServiceClient = new BlobServiceClient(_storageAccessKey);

                // Create the container and return a container client object
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);               

                BlobClient blobClient = containerClient.GetBlobClient(fileName);

                if (await blobClient.ExistsAsync())
                {
                    await using var memoryStream = new MemoryStream();
                    await blobClient.DownloadToAsync(memoryStream);
                    memoryStream.Position = 0;
                    return memoryStream.ToArray();
                }
                return Array.Empty<byte>();
            }
            catch (Exception ex)
            {
                // TODO log exception
                return Array.Empty<byte>();
            }
           
        }
    }
}
