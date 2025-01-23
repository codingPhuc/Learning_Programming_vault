
# example project where hook is used 

```
App
├── Header
├── Shop
│   ├── AvailablePlaces (useState [created in AvailablePlaces], useEffect [created in AvailablePlaces])
│   │   └── Places (useState [created in AvailablePlaces], useEffect [created in AvailablePlaces])
│   │       └── Error (useState [created in AvailablePlaces])
│   └── Product
├── Modal (useRef [created in Modal], useEffect [created in Modal])
│   ├── DeleteConfirmation (useEffect [created in DeleteConfirmation])
│   │   └── ProgressBar (useState [created in ProgressBar], useEffect [created in ProgressBar])
│   └── Error
└── UserInput
    └── input-group
        ├── Expected Return (useState [created in UserInput])
        └── Duration (useState [created in UserInput])
```




# login  interface 

```mermaid 
flowchart TD
	id1[display_background_green]
	id0[display_background_white]
	id2[display_todo] 
	id3[form]
	id4[input_textx2]
	id5[register_button]
	id1-->id2   
	id0--> id3 
	id3-->id4
	id3-->id5
	
```

# Register interface 
```mermaid 
flowchart TD
	id1[display_background_green]
	id0[display_background_white]
	id2[display_todo] 
	id3[form]
	id4[input_textx4]
	id5[register_button]
	id1-->id2   
	id0--> id3 
	id3-->id4
	id3-->id5
	
```




# Home not have tasks list  
```mermaid  
flowchart TD 
	id1[back_ground_color_green]
	id2[form_tasks]
	id3[information_header]
	id4[name_picture]
	id5[logout_button]
	id6[title]
	id7[title_description]
	id8[add_taskbar] 
	id9[tasks_list]
	id10[task]
	id1-->id2-->id3
	id2-->id6
	id2-->id7
	id2-->id8
	id2-->id9
	id9-->id10
	id3-->id4  
	id3-->id5  
```




## Main home page tree structure 
```
App
├── LoginPage
│   └── FormLogin
├── RegisterPage
│   └── FormRegistor
├── ErrorPage
├── MainPage
│   ├── TasksList
│   │   ├── Task
│   │   ├── Task
│   │   ├── Task
│   │   ├── Task
│   │   ├── Task
│   │   ├── Task
│   │   └── Task
│   ├── InputFlied
│   └── ButtonLogOut (image)
```


