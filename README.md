#Dotty Netty Pointy Clicky Siggy Checky Appy
<table><tr><td>
<img alt="Valid signature" src="https://raw.githubusercontent.com/hramrach/VerifyPKCS7.NET/bin/VerifyPKCS7 valid signature.png"/>
</td><td>
<img alt="Missing signature file" src="https://raw.githubusercontent.com/hramrach/VerifyPKCS7.NET/bin/VerifyPKCS7%20no%20signature.png"/>
</td><td>
<img alt="Invalid signature" src="https://raw.githubusercontent.com/hramrach/VerifyPKCS7.NET/bin/VerifyPKCS7 wrong signature.png"/>
</td><td>
<img alt="CA of signer not known" src="https://raw.githubusercontent.com/hramrach/VerifyPKCS7.NET/bin/VerifyPKCS7 unknown signer.png"/>
</td></tr></table>


######Downloads

 * [.Net binary (zip)](https://github.com/hramrach/VerifyPKCS7.NET/blob/bin/VerifyPKCS7.zip?raw=true)
 * [.Net binary (7z)](https://github.com/hramrach/VerifyPKCS7.NET/blob/bin/VerifyPKCS7.7z?raw=true)

######WTF?

This is a Windows .NET application for checking a PKCS#7 signature using the .NET libraries and the built-in system certificate store.

It's quite possible to verify signatures with OpenSSL and write a graphics frontend for that. Using the native Windows libraries and system certificate store alleviates the need to manage two separate certificate stores - one for Windows applications and one for OpenSSL.

Sadly I could not find an application that uses the Windows libraries to verify signatures and works on 64bit Windows. The only scripting bindings I could find was some component that worked on 32bit systems ony.

This application is very simple and pretty much works. It's my first and probably last application in .NET and probably won't get any more development since my VS trial license expired.
