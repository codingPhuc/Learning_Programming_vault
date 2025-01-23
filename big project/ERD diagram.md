
# Post_like 
thiếu mối quan hệ nhiều một với user 
# Post_comment  
mình có làm chức năng reply không  nếu có thì mình sẽ thêm 1 key  la reply comment id và tạo một quan hệ 1 nhiều tự nối vào chính nó 

# save post 
thiếu 1 mối quan hệ hay mày quên diền vào ? 
# post update  
tao thấy mày làm cái post update media này nọ để lưu version nhưng cần lưu ý mấy điều 
1. có cần thiết để lưu version kiểu này không 
2. tại sao lai có nhiều post update mình có làm chức năng reversion lại hay sao giống như quay về post cũ 
3. đơn giản hơn là mình cứ edit post và media dựa vào id khỏi lưu version cũng dc , thấy lưu version thôi cũng 2 3 table rồi 
# Conversation 
cái conversation đó tao thấy mày làm mối quan  hệ 1  1 với conversation member nó phải là 1 nhiều chứ 
# message_seen  
cái status có ý nghĩa gì mày giống như là  
nếu trong group thì mọi người đều coi dc 
nếu single thì chỉ 1 người coi 
tao thấy cái status chỉ cần thiết khi mày tạo 1 chức năng chỉ cho một số nguồi coi trong group thôi
# conv_setting 
là cái này là setting cho 1 người hay của nhiều người mày 
như là  mầy muốn phân coi ai dc gửi message ai dc nhìn thấy tin nhắn ?