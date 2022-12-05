# TrendMachineAPI
TrendMachine API is a RESTful API Server
# Requirement
- [x] README.md file
- [X] endpoints, sample request body, sample response body
- [X] document changes
- [X] 3 API Endpoints & 3 HTTP methods
- [X] MVC software design pattern
- [X] One Controller
- [X] Models in its own folder
- [X] Basic resposne model(statusCode, Description, returned items)
- [X] SQL file(2 tables, 2 primary keys, 1 foreign key, 1 constraint)
# Features
- GET, POST, DELETE gametrend items
# Endpoints
- GET [api/gametrend] - Return all gametrend items
- GET [api/gametrend/{id}] - Return a gametrend item by id
- DELETE [api/gametrend/{id}] - Remove a gametrend item by id
- POST [api/gametrend] - Create a gametrend item with given value
# Sample Request Body 
- 
# Sample Response Body
```cs
    public class GameTrendResponse
    {
        public string StatusCode { get; set; } = default!;
        public string? Description { get; set; }
        public GameInfo?GameInfo { get; set; }
        public List<GameInfo?> gametrend { get; set; }
    }
```
```json
```
# Changes

