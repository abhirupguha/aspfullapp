FROM abhirupguha/winserver:msbuild
SHELL ["powershell"]

COPY . 'C:\\build\\'  
WORKDIR 'C:\\build\\'

 
RUN ["C:\\Program Files (x86)\\MSBuild\\12.0\\Bin\\msbuild.exe", "C:\\build\\ACSSampleApp.sln"]

## Usage: build image, then create container and copy out the bin directory.

CMD ["powershell"]  

