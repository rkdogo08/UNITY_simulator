- 지정된 키를 누른 상태에서 반복적으로 true를 반환함.  
     Input.GetKey  
     


        if(Input.GetKey(KeyCode.A))
        {
            ...;
        }

  
- 지정된 키를 누를 때 한번만 true가 반환됨.   
     Input.GetKeyDown   
     

- 지정된 키가 해제될때 한번만 true 반환됨.   

          Input.GetKeyUp  

   
- 좌우/앞뒤 이동키 & W,A,S,D  
     Input.GetAxis("Horizontal")  
     Input.GetAxis("vertical")   
          
     
 
