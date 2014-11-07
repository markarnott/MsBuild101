@ECHO OFF

WHERE MSBUILD.EXE
IF ERRORLEVEL 1 CALL SetMsBuildPath.bat

SET MSBuildEmitSolution=1

msbuild 2_Targets_And_Tasks\CustomTask\CustomTask.sln

notepad 2_Targets_And_Tasks\CustomTask\CustomTask.sln.metaproj
