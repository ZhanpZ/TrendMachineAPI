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
GET [api/gametrend]
```json
{}
```
GET [api/gametrend/{id}]
```json
{
    "id": 1
}
```
DELETE [api/gametrend/{id}]
```json
{
    "id": 1
}
```
POST [api/gametrend]
```json
{
    "id": 5,
    "name": "god of war",
    "peak_Num": 73529,
    "net_Income": 4411740
}
```
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
{
    "statusCode": "200",
    "description": "GET Success",
    "gameInfo": null,
    "gametrend": [
        {
            "id": 1,
            "name": "cyberpunk",
            "peak_Num": 830387,
            "net_Income": 120000000
        },
        {
            "id": 2,
            "name": "witcher 3",
            "peak_Num": 103329,
            "net_Income": 3099870
        },
        {
            "id": 3,
            "name": "elden ring",
            "peak_Num": 952523,
            "net_Income": 57151380
        }
    ]
}
```
# Changes

