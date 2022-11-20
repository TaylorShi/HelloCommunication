## Quic

### 什么是Quic

> https://quicwg.org

> `Quic`是一个基于UDP的、流多路复用的、加密的传输协议。

![](./Assets/2022-11-21-00-49-31.png)

`Quic`全称`Quick UDP Internet Connection`，发音`quick`，是是谷歌制定的一种基于UDP的低时延的互联网传输层协议。在2016年11月国际互联网工程任务组(IETF)召开了第一次QUIC工作组会议，受到了业界的广泛关注。这也意味着QUIC开始了它的标准化过程，成为新一代传输层协议。

### Quic的优势

与现有的"TLS over TCP"方案相比，QUIC有许多好处：

- 所有数据包都是加密的，握手是通过TLS1.3认证的
- 平行的(可靠和不可靠的)应用数据流
- 在第一次往返中交换应用数据(0-RTT)
- 改进拥堵控制和损失恢复
- 在客户端IP地址或端口的变化中存活
- 无状态负载平衡
- 易于扩展新的功能和扩展

## 相关文章

* [乘风破浪，遇见最佳跨平台跨终端框架.Net Core/.Net生态 - 低延迟通讯设计，.Net 7内置HTTP/3+基于UDP的多路复用加密传输技术](https://www.cnblogs.com/taylorshi/p/16910090.html)