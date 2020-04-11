@ECHO OFF

echo Blocking incoming for "%1"
netsh advfirewall firewall add rule name="%2 in" dir=in action=block program="%1" enable=yes profile=any
echo Blocking outgoing for "%1"
netsh advfirewall firewall add rule name="%2 out" dir=out action=block program="%1" enable=yes profile=any