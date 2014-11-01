@ECHO OFF

WHERE MSBUILD.EXE
IF ERRORLEVEL 1 CALL ..\SetMsBuildPath.bat

msbuild 1_Properties.proj /p:AParamProp=RockOn /nologo