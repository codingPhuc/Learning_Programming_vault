# basic commands 
Nhdjejsh
- `git init`
- create a git repository 
- `git add <filename>`
- git add will add the file you want to add 
- `git status`
- will display the different between the working tree and the staging area 
- `git commit`
- commit change in the index, when you add git commit alone it will give you a vim interface you need to press I then :wq to commit the file 
- `git commit -m <message>`
- will commit it with a message 
- `git push`
- will push it thought a remote repository  , you can have ssh key or password to push to a repository 
- `git pull`
- pull the latest from remote repository 
- `git clone`
- clone repository into a new directory 
- `git version`
- check the version of git 
- `git diff`
- the command to see the different to in file in git 
- `git restore <filename>`
- git restore you can restore previous version of a file 
- `git mv "<filename change >"`
- this is to change the file name of git 
- `git log`
- this is to change the log of the commit you can also add in `--oneline` to make it look more complax 
- `git log -` 
- is to see the change in the commit 
# intermediate command  
- git config --global user.name "coding phuc"
- git config --global user.email "phucnguyenhoang3839@gmail.com"
- the command above will config the email and username of your remote repository 
- `git rm <removefile>`
- is used to remove the file that you used git add to status 
- `git add *.<filetype>`
- you can add any file that have the same extension when you used *
- touch .gitignore 
- the gitignore is a file that you can specify which file should be ignore when added to a remote repository , you can do this by entering the file you want to ignore into the .gitignore  

## adding example 
- git config --global user.name "coding phuc"
- git config --global user.email "phucnguyenhoang3839@gmail.com"
- git add app.js 
- git rm app.js 
- git commit -m "change app.js"
## Ignore example 

- touch log.txt 
- add log.txt name into .gitignore   
- then if you want to ignore a folder name 
- add `/<foldername>` into gitignore 



# branch command  
- `git branch <branchname>`
- create the branch with the name , but you do not move to the branch yet you need to used a diffrent command to switch 
- `git checkout <branchname>`
- go to a different branch in git 
- `git merge <branchname>`
- merge the a different branch with the main branch 
## remote command 
`git fetch` 
- we used git fetch to check is there is a new commit 
- 