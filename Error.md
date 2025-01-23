



# Docker compose watch command fails

when following this guide : https://docs.docker.com/get-started/introduction/develop-with-containers/ 
I see that the guide is incorrect 
https://github.com/docker/getting-started-todo-app/issues/21
what I have learn : 
1. you need to see the repo of the project for a quick fix instead of searching online 
2. do not trust the guide 100% 
3. need to do your own research if more than an hour then  you need to seek help 

Jdjajajajaj
# why does the code  setState  will act different when place before the try catch block 
```
  if (isVaild) {

        try {

          const { confirmPassword, ...userData } = userInformation;

          await registerInToUserAccount(userData);

          navigation.navigate("/");

        } catch (error) {

          errors.email = error.message;

          setFormErrors(errors);

        }

      }

      setFormErrors(errors);

    }
```