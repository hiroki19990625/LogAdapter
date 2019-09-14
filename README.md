# LogAdapter

## Usage

```
LogAdapter adapter = new LogAdapter()
ILogger logger = adapter.Create()
logger.AddCallback(msg => {
  LoggerManager.GetLogger().Log(msg.Data)
  Console.WriteLine(msg.Data)
})
```
