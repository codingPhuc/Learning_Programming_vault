

## first example 
#### **  
Tổng quan**

- Vẽ ERD cho hệ thống quản lý dự án và công việc (todo).
- Người dùng được phân 2 vai trò: `user` và `admin`.
- Một **User** có thể tham gia nhiều **Project** và nhận nhiều **Todo**
#### **Quyền hạn**
- **User**: Quản lý công việc của mình trong các dự án.
- **Admin**: Quản lý tất cả các công việc và dự án.
#### **Theo dõi thời gian**

- **Thêm các field date**: tracking thời gian

Based on the provided ERD image, here’s an outline of all the objects and their properties:
![[Pasted image 20241129224535.png]]
a user is a member of multiple userProject  , user can also own mutiple project  
I see it  make a different in the project that the user own and the project that the user is in  
when  the user have an owner relationship 
when the user have a user relationship it have a is a member of relation   
that why the has member in the project indicading the member that belong to the project 



### **1. User**

- **id**: string _(Primary Key)_
- **userName**: string
- **fullName**: string
- **userEmail**: string
- **userPassword**: string
- **createdDate**: date

---

### **2. Project**

- **id**: string _(Primary Key)_
- **projectName**: string
- **projectDesc**: string
- **startDate**: date
- **endDate**: date
- **createdDate**: date
- **ownerUserId**: string _(Foreign Key to User)_

---

### **3. Task**

- **id**: string _(Primary Key)_
- **taskTitle**: string
- **taskDesc**: string
- **taskStatus**: string
- **startDate**: date
- **deadline**: date
- **createdDate**: date
- **modifiedDate**: date
- **projectId**: string _(Foreign Key to Project)_
- **parentTaskId**: string _(Foreign Key to Task for sub-task relationship)_
- **assignedBy**: string _(Foreign Key to User)_
- **createdBy**: string _(Foreign Key to User)_

---

### **4. UserProject**

- **memberId**: string _(Foreign Key to User)_
- **projectId**: string _(Foreign Key to Project)_
- **PRIMARY KEY (memberId, projectId)**
- **memberRole**: string
- **joinedDate**: date

---

### **Relationships:**

- **User - Project**: One-to-Many (A user can own many projects)
- **Project - Task**: One-to-Many (A project can include many tasks)
- **User - Task**: One-to-Many (A user can be the creator or assignee of multiple tasks)
- **User - UserProject - Project**: Many-to-Many (Users can be members of multiple projects with specific roles)
- **Task - Task**: One-to-Many (Tasks can have sub-tasks)





