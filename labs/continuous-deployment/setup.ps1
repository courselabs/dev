
$appId=[Guid]::NewGuid().ToString().Substring(0,8)

echo '----'
echo '** This script will create the cloud service **'
echo '---'

$gitHubUser=Read-Host -Prompt "What is your GitHub username? (e.g. mine is sixeyed)"

$rgName="rg-$appId"
echo "* Creating Resource Group $rgName"
az group create -l eastus -n $rgName | Out-Null

$planName="ap-$appId"
echo "* Creating App Service Plan $planName"
az appservice plan create -g $rgName -n $planName `
  --is-linux --sku S1 --number-of-workers 2 `
  --only-show-errors | Out-Null

$appName="labscd-$appId"
echo "* Creating Web App $appName"
az webapp create -g $rgName --plan $planName `
  --runtime dotnetcore:6.0 -n $appName `
  --only-show-errors | Out-Null

echo '* Configuring deployment from GitHub'

az webapp config appsettings set `
  --settings PROJECT='labs/continuous-deployment/src/HelloWorldWeb/HelloWorldWeb.csproj' `
  -g $rgName -n $appName `
  --only-show-errors | Out-Null

$gitHubUrl="https://github.com/$gitHubUser/dev.git"
echo "* Using GitHub repo: $gitHubUrl"
az webapp deployment source config `
    -g $rgName -n $appName `
    --manual-integration --branch main --repo-url $gitHubUrl `
    --only-show-errors | Out-Null

echo '----'
echo '** DONE! **'
echo "** You can browse to your website at: http://$($appName).azurewebsites.net"
echo '** (it might not be ready yet)'
echo '---'