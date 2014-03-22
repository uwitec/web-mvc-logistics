for /f "tokens=*" %%a in ('dir obj /b /ad /s ^|sort') do rd "%%a" /s/q
for /f "tokens=*" %%a in ('dir bin /b /ad /s ^|sort') do rd "%%a" /s/q
for /f "tokens=*" %%a in ('dir Zephyr.Bin /b /ad /s ^|sort') do rd "%%a" /s/q


set source=G:\01.¿ª·¢¿ò¼Ü\NuGetPackages\src\Zephyr.Net

del %source%\Zephyr.Data\bin\Release\*.nupkg %target%
del %source%\Zephyr.Utils\bin\Release\*.nupkg %target%
del %source%\Zephyr.Library\bin\Release\*.nupkg %target%
del %source%\Zephyr.Core\bin\Release\*.nupkg %target%
del %source%\Zephyr.Web.Mvc\bin\*.nupkg %target%
del %source%\Zephyr.Web.Sys\bin\*.nupkg %target%