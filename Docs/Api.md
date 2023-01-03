# Bridget Dinning Api

- [Bridget Dinnning Api](#bridget-dinning-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
    - [Login](#login)
        - [Login Request](#login-resquest)
        - [Login Response](#login-response)

## Auth

### Register
```js
POST{{host}}/auth/register
```

#### Register Request

```json
{
    "firstName":"joseph",
    "lastName":"Kouadio",
    "email":"nzij@gmail.com",
    "password":"123pasword!"
}
```
#### Register Response
```js
200 OK
```
```json
{
    "id":"fsfsf-3fef-ere4-44ddf-edfgdgdgdf",
    "firstName":"joseph",
    "lastName":"Kouadio",
    "email":"nzij@gmail.com",
    "token":"eyjhb..dsfsdffer"
}
```
## Login

```js
POST{{host}}/auth/login
```

#### Login Request

```json
{
    "email":"nzij@gmail.com",
    "password":"123pasword!"
}
```
#### Login Response
```js
200 OK
```
```json
{
    "id":"fsfsf-3fef-ere4-44ddf-edfgdgdgdf",
    "firstName":"joseph",
    "lastName":"Kouadio",
    "email":"nzij@gmail.com",
    "token":"eyjhb..dsfsdffer"
}
```