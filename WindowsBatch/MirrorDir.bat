@echo off
set sourcePath=%1
set /p destLetter="Enter the drive letter to mirror to: "
set pathWithoutLettter=%sourcePath:~2%
set destPath="%destLetter%%pathWithoutLettter%
robocopy %sourcePath% %destPath% /s /e /dcopy:DAT /mir /dst