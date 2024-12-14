file helper 
```
const fs = require("fs").promises;

const jwt = require("jsonwebtoken");

function createBearerToken(user) {

  const payload = {

    id: user.id,

  };

  const secret = "your-secret-key";

  const options = { expiresIn: "1h" };

  return jwt.sign(payload, secret, options);

}

function verifyBearerToken(token) {

  const secret = "secretKey";

  

  try {

    const decoded = jwt.verify(token, secret);

    return { success: true, data: decoded };

  } catch (error) {

    return { success: false, error: error.message };

  }

}

  

async function readJSONFile(path) {

  try {

    const jsonString = await fs.readFile(path, "utf8");

    return JSON.parse(jsonString);

  } catch (err) {

    console.error(`Failed to read file ${path}:`, err);

    throw new Error("File read failed");

  }

}

  

async function writeJSONFile(path, data) {

  try {

    await fs.writeFile(path, JSON.stringify(data, null, 2));

  } catch (err) {

    console.error(`Failed to write file ${path}:`, err);

    throw new Error("File write failed");

  }

}

  

const getDataFromRequest = (req) => {

  return new Promise((resolve, reject) => {

    let body = "";

    req.on("data", (chunk) => {

      body += chunk.toString();

    });

    req.on("end", () => {

      resolve(JSON.parse(body));

    });

  });

};

  

module.exports = {

  createBearerToken,

  verifyBearerToken,

  readJSONFile,

  writeJSONFile,

  getDataFromRequest,

};
```
file user 

```
// const fs = require("fs");

// const { Module } = require("module");

// const { buffer } = require("stream/consumers");

// const path = "./user.json";

// const { httpStatusCodes } = require("../../utils/constant");

  

// const { MongoClient } = require("mongodb");

// const uri = 'mongodb+srv://NguyenDucNghia:cmDmebL5168KMJPx@cluster0.gf1bc.mongodb.net/';

// const client = new MongoClient(uri);

  

// function handleLogin(request, response) {

//   const chunks = [];

//   request.on("data", (chunk) => {

//     chunks.push(chunk);

//   });

//   request.on("end", () => {

//     const requestData = JSON.parse(Buffer.concat(chunks).toString());

//     fs.readFile(path, "utf8", (error, data) => {

//       if (error) {

//         console.log(error);

//         response.statusCode = httpStatusCodes.INTERNAL_SERVER_ERROR;

//         response.end("Internal server error");

//         return;

//       }

//       const users = JSON.parse(data);

//       const user = users.find(

//         (u) =>

//           u.username === requestData.username &&

//           u.password === requestData.password

//       );

//       if (user) {

//         var token = `${user.username}.${user.password}`;

//         user.token = token;

//         const index = users.findIndex((u) => u.username === user.username);

//         users[index] = user;

//         fs.writeFile(path, JSON.stringify(users), (error) => {

//           if (error) {

//             console.log(error);

//             response.statusCode = httpStatusCodes.INTERNAL_SERVER_ERROR;

//             response.end("Internal server error");

//             return;

//           }

//         });

//         response.statusCode = httpStatusCodes.OK;

//         response.end(token);

//         return;

//       }

//       response.statusCode = httpStatusCodes.UNAUTHORIZED;

//       response.end("Invalid username or password");

//     });

//   });

// }

  

// function handleRegister(request, response) {

//   const chunks = [];

//   request.on("data", (chunk) => {

//     chunks.push(chunk);

//   });

//   request.on("end", () => {

//     const requestData = JSON.parse(Buffer.concat(chunks).toString());

//     fs.readFile(path, "utf8", (error, data) => {

//       if (error) {

//         console.log(error);

//         response.statusCode = httpStatusCodes.INTERNAL_SERVER_ERROR;

//         response.end("Internal server error");

//         return;

//       }

//       const users = JSON.parse(data);

  

//       const existingUser = users.find(

//         (u) => u.username === requestData.username

//       );

  

// if (existingUser) {

//     user.token = null;

//     const index = users.findIndex(u => u.username === user.username);

//     users[index] = user;

//     fs.writeFile(path, JSON.stringify(users), (error) => {

//         if (error) {

//             console.log(error);

//             response.statusCode = httpStatusCodes.INTERNAL_SERVER_ERROR;

//             response.end("Internal server error");

//             return;

//         }

//     });

//     response.statusCode = httpStatusCodes.OK;

//     response.end("Successfully logged out");

//     return;

// }

// response.statusCode = httpStatusCodes.UNAUTHORIZED;

// response.end("Invalid username");

//       if (existingUser) {

//         response.statusCode = httpStatusCodes.CONFLICT;

//         response.end("Username already exists");

//         return;

//       }

//       const userId = `${requestData.username}_${Date.now()}_${Math.random().toString(36).substring(2, 15)}`

//       const token = `${requestData.username}.${requestData.password}`;

//       const newUser = {

//         username: requestData.username,

//         password: requestData.password,

//         token: token,

//         userId: userId

//       };

  

//       users.push(newUser);

  

//       fs.writeFile(path, JSON.stringify(users), (error) => {

//         if (error) {

//           console.log(error);

//           response.statusCode = httpStatusCodes.INTERNAL_SERVER_ERROR;

//           response.end("Internal server error");

//           return;

//         }

//         response.statusCode = httpStatusCodes.CREATED;

//         response.end(token);

//       });

//     });

//   });

// }

  

// module.exports = {

//   handleLogin,

//   handleRegister,

// };

const { MongoClient } = require("mongodb");

const { httpStatusCodes } = require("../../utils/constant");

// const { createBearerToken, verifyBearerToken } = require("../../utils/helper");

const { createBearerToken, getDataFromRequest } = require("../../utils/helper");

// MongoDB connection URI

const uri =

  "mongodb+srv://NguyenDucNghia:cmDmebL5168KMJPx@cluster0.gf1bc.mongodb.net/";

const client = new MongoClient(uri);

  

// Đảm bảo kết nối tới MongoDB

async function connectToDatabase() {

  try {

    await client.connect();

    return client.db("todo_app");

  } catch (error) {

    console.error("Error connecting to MongoDB:", error);

    throw error;

  }

}

  

async function handleLogin(request, response) {

  try {

    const requestData = await getDataFromRequest(request);

    const db = await connectToDatabase();

    const usersCollection = db.collection("users");

  

    const user = await usersCollection.findOne({

      username: requestData.username,

      password: requestData.password,

    });

    if (user) {

      const userToken = createBearerToken(user._id);

      response.statusCode = httpStatusCodes.OK;

      response.end(userToken);

    }

    // const chunks = [];

    // request.on("data", (chunk) => {

    //   chunks.push(chunk);

    // });

    // request.on("end", async () => {

    //   const requestData = JSON.parse(Buffer.concat(chunks).toString());

  

    //   const db = await connectToDatabase();

    //   const usersCollection = db.collection("users");

  

    //   // Tìm user với username và password

    //   const user = await usersCollection.findOne({

    //     username: requestData.username,

    //     password: requestData.password,

    //   });

    //   console.log;

    //   if (user) {

    //     // const token = `${user.username}.${user.password}`;

    //     // // Cập nhật token cho người dùng

    //     // await usersCollection.updateOne(

    //     //   { username: user.username },

    //     //   { $set: { token: token } }

    //     // );

  

    //     response.statusCode = httpStatusCodes.OK;

    //     response.end(createBearerToken(user._id));

    //   } else {

    //     response.statusCode = httpStatusCodes.UNAUTHORIZED;

    //     response.end("Invalid username or password");

    //   }

    // });

  } catch (error) {

    console.error(error);

    response.statusCode = httpStatusCodes.INTERNAL_SERVER_ERROR;

    response.end("Internal server error");

  }

}

  

async function handleRegister(request, response) {

  try {

    const chunks = [];

    const requestData = await getDataFromRequest(request);

    const db = await connectToDatabase();

    const usersCollection = db.collection("users");

    const existingUser = await usersCollection.findOne({

      username: requestData.username,

    });

    if (existingUser) {

      response.statusCode = httpStatusCodes.CONFLICT;

      response.end("Username already exists");

      return;

    }

    const newUser = {

      username: requestData.username,

      password: requestData.password,

      token: "",

    };

    await usersCollection.insertOne(newUser);

    const user = await usersCollection.findOne({

      username: requestData.username,

      password: requestData.password,

    });

    response.statusCode = httpStatusCodes.CREATED;

    const userToken = createBearerToken(user._id);

    response.end(userToken);

    // request.on("data", (chunk) => {

    //   chunks.push(chunk);

    // });

    // request.on("end", async () => {

    //   const requestData = JSON.parse(Buffer.concat(chunks).toString());

  

    //   const db = await connectToDatabase();

    //   const usersCollection = db.collection("users");

  

    //   const existingUser = await usersCollection.findOne({

    //     username: requestData.username,

    //   });

  

    //   if (existingUser) {

    //     response.statusCode = httpStatusCodes.CONFLICT;

    //     response.end("Username already exists");

    //     return;

    //   }

  

    //   const token = `${requestData.username}.${requestData.password}`;

    //   const newUser = {

    //     username: requestData.username,

    //     password: requestData.password,

    //     token: token,

    //   };

    //   // const userId = await usersCollection.findOne({

    //   //   username: requestData.username,

    //   //   password: requestData.password,

    //   // });

  

    //   // Thêm user mới vào MongoDB

    //   await usersCollection.insertOne(newUser);

  

    //   const userId = await usersCollection.findOne({

    //     username: requestData.username,

    //     password: requestData.password,

    //   });

    //   response.statusCode = httpStatusCodes.CREATED;

  

    //   response.end(createBearerToken(userId._id));

    // });

  } catch (error) {

    console.error(error);

    response.statusCode = httpStatusCodes.INTERNAL_SERVER_ERROR;

    response.end("Internal server error");

  }

}

  

module.exports = {

  handleLogin,

  handleRegister,

};
```

cors is the resone why this is wrong 

```
const express = require('express');

const { createServer } = require('http');

const cors = require('cors');

const router = require('./router');

  

const hostname = '127.0.0.1';

const port = 3000;

  

const app = express();

  

// Use CORS middleware

app.use(cors());

  

// Use JSON middleware

app.use(express.json());

  

// Use your router

app.use((req, res) => {

  router.run(req, res);

});

  

// Create HTTP server

const server = createServer(app);

  

server.listen(port, hostname, () => {

  console.log(`Server running at http://${hostname}:${port}`);

});
```



# key in react 

  listItems.forEach((element) => {

    if (element.name.toLowerCase().indexOf(filterText.toLowerCase()) === -1) {

      return;

    }

    if (isStockOnly && !element.stocked) {

      return;

    }

    if (element.category !== passCategory) {

      rows.push(

        <ItemCategory category={element.category} key={element.category} />

      );

    }

    rows.push(<Item product={element} key={element.name}></Item>);

    passCategory = element.category;

  });
  the  key={element.category} is for identifing which element is unique if I did not add  the element.name it will create an error leading to me adding it continusly 
  