#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.




ScreenHeight = 2160
TaskbarHeight = 30


<#numpad0::
	WinRestore, A
	WinMove, A,, 1280, 720,
return


; Bottom numpad row (1280, 1280, 1280)

<#numpad1::
	WinRestore, A
	WinMove, A,, 0, 720, 1280, 1280
return

<#numpad2::
	WinRestore, A
	WinMove, A,, 1280, 720, 1280, 1280
return	
	
<#numpad3::
	WinRestore, A
	WinMove, A,, 2560, 720, 1280, 1280
return


; Middle numpad row (960, 1920, 1920)

<#numpad4::
	WinRestore, A
	WinMove, A,, 0, 720, 960, 1280
return

<#numpad5::
	WinRestore, A
	WinMove, A,, 960, 720, 1920, 1280
return	
	
<#numpad6::
	WinRestore, A
	WinMove, A,, 2880, 720, 960, 1280
return


; Top numpad row (1120, 1600, 1120)
		
<#numpad7::
	WinRestore, A
	WinMove, A,, 0, 720, 1120, 1280
return

<#numpad8::
	WinRestore, A
	WinMove, A,, 1120, 720, 1600, 1280 
return	
	
<#numpad9::
	WinRestore, A
	WinMove, A,, 2720, 720, 1120, 1280
return


; Shift + bottom numpad row

<#numpadEnd::
	WinRestore, A
	WinMove, A,, 640, 720, 1280, 1280
return

<#numpadDown::
	WinRestore, A
	WinMove, A,, 640, 720, 2560, 1280
return	
	
<#numpadPgDn::
	WinRestore, A
	WinMove, A,, 1920, 720, 1280, 1280
return


; Shift + middle numpad row

<#numpadLeft::
	WinRestore, A
	WinMove, A,, 960, 720, 960, 1280
return
	
<#numpadRight::
	WinRestore, A
	WinMove, A,, 1920, 720, 960, 1280
return


; Shift + top numpad row

<#numpadHome::
	WinRestore, A
	WinMove, A,, 320, 720, 1600, 1280
return

<#numpadUp::
	WinRestore, A
	WinMove, A,, 320, 720, 3200, 1280
return
	
<#numpadPgUp::
	WinRestore, A
	WinMove, A,, 1920, 720, 1600, 1280
return



