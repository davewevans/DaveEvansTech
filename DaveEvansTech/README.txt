
Website is stored on Azure as a Static Web App
https://docs.microsoft.com/en-us/learn/modules/publish-app-service-static-web-app-api-dotnet/1-introduction


If changes made using Tailwind CSS, remove the underscores in __package.json and run: npm run buildcss
package.json and package-lock.json interfer with the GitHub action to build since the action wants to 
add Node.js to the root (or something like that).