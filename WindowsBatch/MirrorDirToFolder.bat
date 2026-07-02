@echo off
set sourcePath=%1
set /p destPath="Enter path to mirror to: "
robocopy %sourcePath% %destPath% /s /e /dcopy:DAT /mir /dst