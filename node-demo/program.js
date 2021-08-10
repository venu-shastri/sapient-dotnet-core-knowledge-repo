const WebServer=require('./webServer.js');
const webServerInstance=new WebServer(3000);

webServerInstance.initialize();
webServerInstance.registerDefaultMiddleware();
webServerInstance.start();
