@ECHO OFF

WHERE MSBUILD.EXE
IF ERRORLEVEL 1 CALL ..\SetMsBuildPath.bat

msbuild 1_Conditions.proj /p:MyProp=Something /nologo