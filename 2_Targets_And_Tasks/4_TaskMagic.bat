@ECHO OFF

WHERE MSBUILD.EXE
IF ERRORLEVEL 1 CALL ..\SetMsBuildPath.bat

pushd CustomTask
copy after.CustomTask.sln.xml after.CustomTask.sln.targets 
msbuild CustomTask.sln /nologo

