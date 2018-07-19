# Aegean

Bitcoin tumbler/mixer using XMR.TO

<p align="center"> <img src="https://github.com/prayank23/Aegean/blob/master/screenshot.png?raw=true"/> </p>

**What?**
This is a Windows application project (VB.NET), user has to input a BTC destination address, amount and return BTC address. Tool gives a BTC address and amount as output which is used for deposit to make the private transaction.

Current Version: 0.1.0

**How?**
In the background, the BTC destination address is used in XMR.TO APIs to get the monero address, which is used next in shapeshift APIs to get the BTC deposit address for btc_xmr trade. So, user sends BTC to shapeshift which is sent to XMR.TO and they forward the BTC payment to the destination address.

Timeout Value: 3 minutes

(Optional) Proxy settings: Options->Proxy lets any user configure tor proxy or other proxy for incoming and outgoing connections made by the application

.NET Framework used: 4.5

**Why?**
Fuck Governments

_Reference links used during the project:_

https://xmrto-api.readthedocs.io/en/latest/api_v2.html

https://info.shapeshift.io/api

https://blockchair.com/bitcoin/blocks

_Author credits for cat picture:_ 
<div>Icons made by <a href="http://www.freepik.com" title="Freepik">Freepik</a> from www.flaticon.com 







