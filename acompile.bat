
cls

Del *.exe

@If "%ProgramW6432%" NEQ "" goto 64-bit

@Echo "32-bit"
@SET VBC="C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe" 
goto compile

:64-bit
@Echo "64-bit"
@SET VBC="C:\Windows\Microsoft.NET\Framework64\v4.0.30319\vbc.exe"

:compile

%VBC% /t:exe /out:Zinchenko.exe .\VB\Zinchenko.vb




rem @pause>nul
