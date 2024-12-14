
const fs = require("fs").promises;

const jwt = require("jsonwebtoken");

  

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

  

function generateJwtToken(user) {

  const payload = {

    id: user.id,

  };

  

  const secret = "your-secret-key";

  const options = { expiresIn: "2h" };

  

  return jwt.sign(payload, secret, options);

}

function verifyJwtToken(token) {

  const secret = "your-secret-key";

  

  try {

    const decoded = jwt.verify(token, secret);

    return { success: true, data: decoded };

  } catch (error) {

    return { success: false, error: error.message };

  }

}

  

module.exports = {

  generateJwtToken,

  verifyJwtToken,

  readJSONFile,

  writeJSONFile,

  getDataFromRequest,

};