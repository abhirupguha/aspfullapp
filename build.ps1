Remove-Item ACSSampleApp\\bin -Recurse 

Remove-Item DataLayer\\bin -Recurse 

docker build --build-arg HTTP_PROXY=%HTTP_PROXY% --build-arg HTTPS_PROXY=%HTTPS_PROXY% -f build.Dockerfile -t abhirupguha/testimage1 .


docker create --name extract_asset abhirupguha/testimage1


docker cp extract_asset:C:\\build\\ACSSampleApp\\bin .\\ACSSampleApp\bin

docker rm extract_asset


docker build -f Dockerfile -t testapp:v1 .



