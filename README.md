# HTTP通讯



## V2.0

不完善

客户端正常使用

服务端那里只有	开启服务	发送UTF8（可选中列表里面的客户端进行选中发送，不选中则对全部客户端发送）

![main_ui](main_ui.png)





## 其他

### Socket

..............



### Task

把里面的代码丢进线程池，防止主线程(UI)卡死



### Invoke

跨线程调用控件的时候需要使用，一般与Task嵌套？

```c#
Invoke(new Action(() =>
{
    //方法;

}));
```





### IPEndPoint


IPEndPoint新建实例的时候需要输入	ipAddress,port	即ip+端口



### Dictionary (字典)

简单的说，可以将key，value一对一对的保存，可以通过key查询返回一个value

```c#
CurrentClientsList.Add(client, socketClient);
```

(`client` (Key)：是“标识符”，不是客户端本身,`socketClient` (`Value`)：是“通信通道”，也不是物理客户端)

勉强能说soketClient才是真正的客户端



```c#
CurrentClientsList[client]?.Send(data);
```

这行代码能编译通过并运行，证明了获取到的是 Socket 对象

- **操作 (`CurrentClientsList[...]`)**：这是字典的索引器（Indexer）。它的作用是根据提供的 Key 去查找对应的条目。
- **输出 (`result`)**：返回的是存储在该 Key 下的 **Value**。

