1.25 mb to 2.78  
accuracy drop off like a stone 
worst then when you started so this is not going to work 
using regular low  rounding  anything is round to   0  
building general  model    
out lier  programming around it   

![[Pasted image 20250213191348.png]] 
the same graph is found 

![[Pasted image 20250213191406.png]] 


16  bit will not have make  the nnumber  0 due to it being larger 
![[Pasted image 20250213191530.png]]  
any thing time 0 a 0  
scaling  


![[Pasted image 20250213191758.png]] 
switch to a different function 16  bit is okay now 

![[Pasted image 20250213191828.png]] 
have a recovery to 0 
decreasing the traning 


![[Pasted image 20250213191857.png]] 
deep seek write a  custome  
tile  break it into seperate tile 
What is  a Tensor core  to cuda core used 32-bit  for paralle processing  Tensor for ml multipitication for neuro network 

![[Pasted image 20250213192145.png]]
the biggest number 437 smallest number ioo2  ioo2  to  437 same thing do in quantization 
bunch of number ioo2 to 437  if fp8 problem  is occure there is a really big one and smalle one  

choose a chunk size the odd of getting really big one and small one  is really low 
128  find out what the biggest number what the smallest number , write those as your  

batch averaging a radian  Deep Seek  quantization  Implementation 
FP8 only work on Hopper GPU
not to used an Invidia library  black box  which do call these five function 
non export restricted GPU  
they could optimize the code to work best on the availible  hardware 
having a code  don't need to call Nvidia  not not a bad way to go to be able to control your destiny 
Tencent  coming out to out with GPU  

## Increasing accumulation  

Summary 
DEEPSeek  did a good job taking  advantage  of the features Nvida offred to spped traning 
substantially reduced their training time and cost 
they took advantage of 8 bit tranning features on hopper when possible and lower  powered GPUs vie thier tech 

Can wait to ee how they take advantage of FP6 and FP4 in blackwell 



Nvidia have a library for block wide rescaling the current support  in pytouch thought have not rescalling the number cannot be bigger and smaller than what I support 

https://arxiv.org/abs/2412.19437  
Is FP8 a model created by the deep seek creator correct ?  Or is it a model that the deep seek creator piggy back off of NIvada library ? 
FP8 is a standard datatype supported by most languages and GPU libraries. The problem the DeepSeek engineers solved is that many numbers in training an LLM need to be either bigger that 447 or smaller than 0.002. So, instead of just storing as FP8, they quantized to FP8, which means there's a scaling factor.


The envidia  Cude  will decide what you will do to the gpu , most of the magic is a high level  decription of what you want 2 large matrix it cannot multiply in the gpu  
there is multiple layer in pytouch and Nvidia GPU 