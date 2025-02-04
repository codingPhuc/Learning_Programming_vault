# different type of file management 
there are different type of file management , there is google drive for all type of file , mega for storing large file  but Git is optimize the most for controlling version of a text file combine with Github a place for stored for those file 

# what is git ? 

**Distributed Version Control:** This is a system that records changes to files over time. It allows you to revisit various versions of a file or set of files later on.

**File Management Technology:** This technology helps in managing and organizing files efficiently.

**Coordination Among Developers:** This system allows multiple developers to work on different networks. It keeps track of who made what changes and when, providing a clear history of modifications.

**Reversion:** One of the key features is the ability to revert back to any previous version at any time.

**Local and Remote:** The system works both locally and remotely. This means you don’t need an internet connection to work with it.

**Three Different Environments in Git:**

1. **Working File:** This is the actual file in GitHub that you’re currently working on.
2. **Staging:** This is a ‘holding pen’ where changes are kept before they are committed. It allows you to prepare and review your commits before making them.
3. **Commit:** This is the final step where your changes are added as a log or an entry in the history book. This makes it easy to track changes over time.

I hope this makes the information more readable! Let me know if you have any other questions. 😊

## benefit of git 
- git is like a savior for storing of file history  
- enable the ability of returning to the pass  
	-  git is more used than google drive for this ability  
	- git can relocate , return to the pervious point in a commit if we know enough 
why should we choose GitLab > GitHub 
- the price 
- Personal benefit 
$\rightarrow$ choose which tech fit the scenario the best 

## tool in git  
principle `Do not reinvent the wheel` 
if a tools that control git is broken used other tools 
an example of a tools is git Kraken 


## git  repository

like all other file storage or data storage in general git have a provider  
![[git and google drive 2024-06-08 09.12.54. excalidraw]] 
for file storage there is google drive and for git there is Github GitLab and Bitbucket  , so think of a repository like a cloud storage where you store your items without using your own computer memory 
git repository is similar kind of storage to store text file , it is a unit of management in git .A commit in git repository is like a change in a folder , each change is a commit 
best practice : 
- do not one storage for multiple project , instead used multiple repo for multiple project 
-  there are many scenario where one project can be slip up into multiple repo like shoppe page where backend and front end are split so split it correctly  

# how git work  
first for git to work you need to create a working folder 
- you can create it by using a `git init command` 
- you can also create it by cloning an online repo 
- working directory are places that enable git command and git changes to be run , a hidden folder name .git is an indicator of a working directory 
- staging area is where the all the changes you choose is place inside, when commit the file will be allow to change
	-  it is like a place you place all your packages  and commit is when you push all those packages to your storage 
 PHASE TO  FIGHT BY `EVEN IF YOU HOUSE IS BURNING DOWN PUSH CODE FIRST THEN RUN`
- commit message need to have a clear understanding format 
	- `Branch name | what task are you working on`
![[Drawing 2024-06-08 09.29.08.excalidraw |20000]] 
process for git push : 
1.  when the file is updated with new change it will be put into the unstage change area  
2. if the file is added to the stage change we with a command like `add` 
3. we can then `commit` with  a message  , this will turn the file into a  commit 
4. push the change in local to a remote repository  
fetch is like checking for update in the remote repo 
process for git fetch : 
- fetch the commit from a remote repo to the local repo 
pull is install and download the update 
process for git pull 
- this is like fetch but commit that is present in both local and remote repo is merge together for consistency 
## downloading git 
- linux (debian)
`sudo apt-get install git`
- linux ( fedora)
` sudo ym install git`
- window 
- download online and run the .exe package 

# GIT concepts  
- keep track of code history 
- take "snapshots" of your files 
- you decide when to take a snapshot by making a "commit"
- [[git command]]
- [git command cheat sheat](https://cs.fyi/guide/git-cheatsheet) 
## branches in git 
branches is used when multiple people are working on the same project you create branches so that the work flow is not interrupted    
- branch when initializing the git repo with `init `there should be a branch call main , in older version it is call master 
- branches are most used for managing feature that other people work on  
- programmer can work independently without conflict 
- to resolve conflict on branch we used thing like  
- rebase like the name `re` is reallocate and `bash` is root , so what it is saying is that it is reallocating the feature branch to the newest commit of the main branch  , this is like copy the branch deleted it then paste it to the new commit  . This will cause the branch to be recognizable with the branch on origin so we need to force push to force the updated 
![[Drawing 2024-06-08 09.52.51.excalidraw]]
here F4 is another branch in the git repo , the main branch contain all function F1 $\rightarrow$ F5  , but F4 was created when F2 was create now in the process of continuing F4 , F3 was created causing F4 to be out of date. to make sure that F4 is updated with the correct updated code we will used rebase , rebase enable F4 to root to be connected with F3 instead of F2 
think of it like timeline originally F4 was in a timeline where F2 exit but now the timeline has change where F4 is in a timeline where F3 exit that is the power of rebase , it delete the original timeline in a favor of a newer one 
Merge operate the same but with a few tweet , merge enable the timeline to both exit but F4 is connected mainly to the change in F3 and do not interact at all with the change in F2 . This can be user for dev who wan to return to F4 timeline where it is connected to F2 . 

|         | merge                                | rebase                                             |
| ------- | ------------------------------------ | -------------------------------------------------- |
| action  | enable for timeline to both exit     | delete the old timeline and create a new one       |
| benefit | enable dev to return to old timeline | make the commit history more readable and convince |
### why force push is needed 

![[Drawing 2024-06-08 10.25.36.excalidraw]]
there is two branches in this picture one is the feature branch containing F3 and the second is the  main branches . the branches and arrow color in read is the change when pull from the repo , the repo added in 2 new commit F4 and F5 
here we push the branch F3 into our repo this cause no problem because 3 have not been created yet. Then we pull the change back from the repo to local, then rebase the branch F3 and main in our local , but when we push the new F3 rebase branch it does not let us , this is because the id of branch are different when we rebase we do not just uproot the branch but we also copy and paste the new branch causing a conflict on both local and repo so we are force to used force push so that the new change is added 
### conflict  

![[Drawing 2024-06-08 10.15.25.excalidraw]]
conflict is created when a change in a branch commit is align with the change in the main commit causing 2 different file of code to be incompatible when merge or rebase. to resolve the conflict we must choose with change to take the which change to not 


### pull 
![[Drawing 2024-06-12 12.50.52.excalidraw]]
- here before pull local is missing implementation from origin  
- if we `pull ` or `fetch` then the it will move on the stage two  it will create another branch that have the new commit 
- when the pull is competed it will merge the local with  branch create by fetch  

### why rebase instead of merge 

![[Pasted image 20240612131150.png]]
rebase cause the branch to be more petty and compact  when compare  to merge , so people that want a cleaner history will prefer rebase then merge . On the other hand , merge will make each commit more detail , so it is advise to choose the commit bases on the situation 
## branches in git  

### Remote and local interaction  

![[remote and local 2024-06-12 11.17.18.excalidraw]]
there is two different git repository that should be noted , one is the Main branch or Master branch , the other is the Remote or Origin branch. The remote branch is like a storage that every user that have permission can interact with while the local branch are for 1 user only . 
Detail between the remote branch and origin branch : 
- a remote update is cause by another person updating the same branch on remote 
- to synchronize the development project , we need to pull from the remote branch to the main branch  

### most common step when working on git and github 
these are the most common step that people used to work with git or github 
- [[git command]] 
