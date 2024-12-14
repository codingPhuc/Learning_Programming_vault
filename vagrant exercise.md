![[Pasted image 20241123112906.png]] 

# solution 
```


git clone https://github.com/finallyayo/covid-node 
sudo apt update
curl -fsSL https://deb.nodesource.com/setup_10.x | sudo -E bash -
sudo apt install -y nodejs
cd covid-node 
npm install
cd .. 
sudo apt install -y apt-transport-https ca-certificates curl software-properties-common
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -
sudo add-apt-repository -y "deb [arch=amd64] https://download.docker.com/linux/ubuntu bionic stable"
sudo apt update -y
sudo apt install -y docker-ce
sudo usermod -aG docker vagrant
sudo usermod -aG docker $USER
cat > Dockerfile << 'EOF'
> FROM node:16-alpine
>
> WORKDIR /app
yarn --frozen-lockfile

# Copy source code
COPY . .

# Expose the application port
EXPOSE 4000

# Start the appl>
> # Copy and install dependencies
> COPY package.json yarn.lock ./
> RUN yarn --frozen-lockfile
>
> # Copy source code
> COPY . .
>
> # Expose the application port
> EXPOSE 4000
>
> # Start the application
> CMD yarn start
> EOF
newgrp docker
docker build -t covid
docker run -p 4000:4000 covid
```

# how to present your solution 
 what you did : 
- talk about the problem  
how you did it : 
- what application did you install for the problem 
- how did you used nginx  
- 
why you did it : 