@ECHO OFF

WHERE MSBUILD.EXE
IF ERRORLEVEL 1 CALL ..\SetMsBuildPath.bat

::Outdir will put solution output anywhere you want it.
msbuild ..\2_Targets_And_Tasks\CustomTask\CustomTask.sln /p:Outdir=%~pd0\MagicOutput /nologo