### API Specification

#### Account

**API Register Account**
- **Endpoint:** `http://127.0.0.1:3000/register`
- **Method:** [`POST`]
- **Description:** Create new account
- **Request Body:**
  ```json
  {
    "username": "string",
    "password": "string"
  }
  ```
- **Response:**
  - **Status:** `200` (Create success), `400` (Create failed), `500` (Server Error)
  - **Data:** `null`

**API Login Account**
- **Endpoint:** `http://127.0.0.1:3000/login`
- **Method:** [`POST`]
- **Description:** Login account
- **Request Body:**
  ```json
  {
    "username": "string",
    "password": "string"
  }
  ```
- **Response:**
  - **Status:** `200` (Login success), `400` (Login failed), `500` (Server Error)
  - **Data:** 
    ```json
    {
      "account": {
        "username": "string",
        "IDU": "string",
        "token": "string"
      }
    }
    ```

#### Note

**API Get All Notes**
- **Endpoint:** `http://127.0.0.1:3000/get-task`
- **Header:** `Token Login`
- **Method:** [`GET`]
- **Description:** Get all notes of Account with IDU from token login
- **Request Body:** `null`
- **Response:**
  - **Status:** `200` (Get success), `400` (Get failed), `500` (Server Error)
  - **Data:** 
    ```json
    {
      "notes": [
        {
          "ID": "string",
          "name": "string",
          "isDone": "boolean",
          "ownerId": "string"
        }
      ]
    }
    ```

**API Get Note by ID**
- **Endpoint:** `http://127.0.0.1:3000/get-task/{ID}`
- **Header:** `Token Login`
- **Method:** [`GET`]
- **Description:** Get note by ID of Account with IDU from token login
- **Request Body:** `null`
- **Response:**
  - **Status:** `200` (Get success), `400` (Get failed), `500` (Server Error)
  - **Data:** 
    ```json
    {
      "note": {
        "ID": "string",
        "name": "string",
        "isDone": "boolean",
        "ownerId": "string"
      }
    }
    ```

**API Add Note**
- **Endpoint:** `http://127.0.0.1:3000/add-task`
- **Header:** `Token Login`
- **Method:** [`POST`]
- **Description:** Add new note
- **Request Body:**
  ```json
  {
    "name": "string",
    "isDone": "boolean",
    "ownerId": "string"
  }
  ```
- **Response:**
  - **Status:** `200` (Add success), `400` (Add failed), `500` (Server Error)
  - **Data:** 
    ```json
    {
      "note": {
        "ID": "string",
        "name": "string",
        "isDone": "boolean",
        "ownerId": "string"
      }
    }
    ```

**API Remove Note**
- **Endpoint:** `http://127.0.0.1:3000/delete-task/{ID}`
- **Header:** `Token Login`
- **Method:** [`DELETE`]
- **Description:** Remove note
- **Request Body:** `null`
- **Response:**
  - **Status:** `200` (Remove success), `400` (Remove failed), `500` (Server Error)
  - **Data:** 
    ```json
    {
      "note": {
        "ID": "string",
        "name": "string",
        "isDone": "boolean",
        "ownerId": "string"
      }
    }
    ```

**API Edit Note**
- **Endpoint:** `http://127.0.0.1:3000/update-task/{ID}`
- **Header:** `Token Login`
- **Method:** `PATCH`
- **Description:** Edit note
- **Request Body:**
  ```json
  {
    "name": "string",
    "isDone": "boolean",
    "ownerId": "string"
  }
  ```
- **Response:**
  - **Status:** `200` (Edit success), `400` (Edit failed), `500` (Server Error)
  - **Data:** 
    ```json
    {
      "note": {
        "ID": "string",
        "name": "string",
        "isDone": "boolean",
        "ownerId": "string"
      }
    }
    ```



