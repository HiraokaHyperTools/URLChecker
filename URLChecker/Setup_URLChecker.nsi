; example2.nsi
;
; This script is based on example1.nsi, but it remember the directory, 
; has uninstall support and (optionally) installs start menu shortcuts.
;
; It will install example2.nsi into a directory that the user selects,

;--------------------------------

Unicode true

!define APP "URLChecker"

!system 'DefineAsmVer.exe "bin\DEBUG\${APP}.exe" "!define VER ""[SVER]"" " > Tmpver.nsh'
!include "Tmpver.nsh"
!searchreplace APV ${VER} "." "_"

!system 'MySign "bin\DEBUG\${APP}.exe"'
!finalize 'MySign "%1"'

; The name of the installer
Name "${APP} ${VER}"

; The file to write
OutFile "Setup_${APP}.exe"

; The default installation directory
InstallDir "$PROGRAMFILES\${APP}"

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\${APP}" "Install_Dir"

; Request application privileges for Windows Vista
RequestExecutionLevel admin

XPStyle on

;--------------------------------

; Pages

Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "Example2 (required)"

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File /r /x "*.vshost.*" "bin\DEBUG\*.*"
  
  ; Write the installation path into the registry
  WriteRegStr HKLM "SOFTWARE\${APP}" "Install_Dir" "$INSTDIR"
  
  WriteRegStr HKLM "SOFTWARE\RegisteredApplications" "URLChecker" "Software\Clients\StartMenuInternet\URLChecker\Capabilities"
  
  WriteRegStr HKLM "Software\Clients\StartMenuInternet\URLChecker\Capabilities" "ApplicationDescription" "URLChecker は URL の検査結果を表示します。"
  WriteRegStr HKLM "Software\Clients\StartMenuInternet\URLChecker\Capabilities" "ApplicationIcon" "$INSTDIR\${APP}.exe,0"
  WriteRegStr HKLM "Software\Clients\StartMenuInternet\URLChecker\Capabilities" "ApplicationName" "${APP}"
  
  WriteRegStr HKLM "SOFTWARE\Clients\StartMenuInternet\URLChecker\Capabilities\URLAssociations" "http" "${APP}"
  WriteRegStr HKLM "SOFTWARE\Clients\StartMenuInternet\URLChecker\Capabilities\URLAssociations" "https" "${APP}"

  WriteRegStr HKCR "${APP}" "URL Protocol" ""
  WriteRegStr HKCR "${APP}" "FriendlyTypeName" "${APP}"

  WriteRegStr HKCR "${APP}\Application" "ApplicationDescription" "URLChecker は URL の検査結果を表示します。"
  WriteRegStr HKCR "${APP}\Application" "ApplicationIcon" "$INSTDIR\${APP}.exe,0"
  WriteRegStr HKCR "${APP}\Application" "ApplicationName" "${APP}"
  WriteRegStr HKCR "${APP}\Application" "AppUserModelId" "${APP}"

  WriteRegStr HKCR "${APP}\DefaultIcon" "" "$INSTDIR\${APP},0"
  
  WriteRegStr HKCR "${APP}\shell\open\command" "" '"$INSTDIR\${APP}.exe" "%1"'

  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP}" "DisplayName" "${APP}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP}" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP}" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP}" "NoRepair" 1
  WriteUninstaller "$INSTDIR\uninstall.exe"
  
SectionEnd

;--------------------------------

; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP}"
  DeleteRegKey HKLM "SOFTWARE\${APP}"

  DeleteRegKey HKCR "${APP}\shell\open\command"
  DeleteRegKey HKCR "${APP}\shell\open"
  DeleteRegKey HKCR "${APP}\shell"
  DeleteRegKey HKCR "${APP}\Application"
  DeleteRegKey HKCR "${APP}"

  DeleteRegKey HKLM "SOFTWARE\Clients\StartMenuInternet\URLChecker\Capabilities\URLAssociations"
  DeleteRegKey HKLM "Software\Clients\StartMenuInternet\URLChecker\Capabilities"
  DeleteRegKey HKLM "Software\Clients\StartMenuInternet\URLChecker"

  ; Remove files and uninstaller
  Delete "$INSTDIR\URLChecker.*"
  Delete "$INSTDIR\uninstall.exe"

  ; Remove directories used
  RMDir "$INSTDIR"

SectionEnd
