# Electric-wave
基于c#、socket开发的windows图形化局域网通信工具，中文名叫“电波”

### 环境依赖
net5.0-windows

### 部署步骤

1. 运行Electric-wave/Electric-wave-server/bin/Debug/net5.0-windows/EwServer.exe
2. 同时输入本机ip和监听端口，开始监听
3. 运行Electric-wave/Electric-wave-server/bin/Debug/netcoreapp3.1/EwClient.exe
4. 输入服务器ip和监听端口，连接

### 目录结构描述
├── Readme.md                   // help

├── Electric-wave-client        // 客户端  
│   ├── bin                                //  
│   ├── obj								//  
│   ├── 63Client.sln        		 //   
│   ├── EwClient.csproj          //   
│   ├── EwClient.csproj.user //   
│   ├── Form1.cs         			//   
│   └── Form1.Designer.cs	//   

├── Electric-wave-server        // 服务端  
│   ├── bin                                 //  
│   ├── obj							 	//  
│   ├── 62Server.sln       	 	 //   
│   ├── EwServer.csproj          //   
│   ├── EwServer.csproj.user //   
│   ├── Form1.cs         		 	//   
│   └── Form1.Designer.cs 	//   

### v1.0.1 版本内容更新

1. 界面改动，现在服务端和客户端的页面初始大小是一样的了



### 待更新

1. 客户端发送震动



