using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DaveEvansTech.Models;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;

namespace DaveEvansTech.Helpers
{
    public class BriefFormService
    {        
        
        private const string FileName = "brief_form.json";

        public BriefFormService()
        {
        }

        public List<BriefSection> GetBriefSections()
        {
            string path = Path.Combine("wwwroot", "json", FileName);
            string jsonText = File.ReadAllText(path, Encoding.UTF8);
            var sections =  JsonSerializer.Deserialize<List<BriefSection>>(jsonText, new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true
            });
            return sections;
        }
    }
}