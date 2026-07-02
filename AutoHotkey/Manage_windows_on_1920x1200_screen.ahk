#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.




ScreenHeight = 1200
TaskbarHeight = 30


<#numpad0::
	WinRestore, A
	WinMove, A,, 320, 200, 1280, 800
return


<#numpad2::
	WinRestore, A
	WinMove, A,, 320, 0, 1280, ScreenHeight - TaskbarHeight 
return	
	

<#numpad5::
	WinRestore, A
	WinMove, A,, 480, 0, 960, ScreenHeight - TaskbarHeight 
return	


<#numpad8::
	WinRestore, A
	WinMove, A,, 160, 0, 1600, ScreenHeight - TaskbarHeight 
return	
	



