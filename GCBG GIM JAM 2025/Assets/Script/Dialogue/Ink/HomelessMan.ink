

#Speaker:Dr.Hyde #layout:left #portrait:Dr_Hyde
#Speaker:  #portrait:default 
#Speaker:Homeless Man  #layout: left #portrait:HomelessMan

-> main

===main===
In the biting cold of the ruined city, Dr. Hyde encountered a shivering homeless man huddled in the shadows of a collapsed overpass #Speaker:  #portrait:default 

His feature, albeit had weathered due to the environement, still retained some of its sharpness. #Speaker:  #portrait:default 

"...Sir? What troubled you? Anyting I could help you with..?" #Speaker:Dr.Hyde #layout:left #portrait:Dr_Hyde

"I'm freezing... the air is as freezing as always.."  #Speaker:Homeless Man  #layout: left #portrait:HomelessMan

"A little bit of fire would be good.. I can definitely use itto warm my body, to cook a meal... with that, maybe I can survive for some more days." #Speaker:Homeless Man  #layout: left #portrait:HomelessMan

+ [Give Lighter]
    Moved by compassion and guilt, Hyde retrieved a battered lighter from his coat pocket and extended it toward the man. #Speaker:  #portrait:default 
    -> Good
    
    
+ [Ignore Him]
    Dr. Hyde can feel his guilt starting to take root on his mind, yet, in another turn of fate, he hesitated, his mind heavy with doubts. #Speaker:  #portrait:default 
    -> Bad
    
    
    ===Good===
    VAR addZinc = true
    "Here, take this. It may be small, but I hope it can help you." #Speaker:Dr.Hyde #layout:left #portrait:Dr_Hyde
    
    "Thank you, kind soul. Wait a moment, I have something for you. It's not something big, but it may help you" #Speaker:Homeless Man  #layout: left #portrait:HomelessMan
    
    The homeless handed a pocket of an ashen-colored powder. #Speaker:  #portrait:default 

    "Here, this is a zinc dust—my humble token of gratitude." #Speaker:Homeless Man  #layout: left #portrait:HomelessMan
    
    "Please accept it, this could help you to chase away those wild, broken, wolf robot. They usually roam this area on midnight." #Speaker:Homeless Man  #layout: left #portrait:HomelessMan
    
    
    "Thank you." #Speaker:Dr.Hyde #layout:left #portrait:Dr_Hyde
    
    With a firm nods, Dr. Hyde continued his journey. #Speaker:  #portrait:default 
    
    ->END
    
    ===Bad===
        VAR AddZinc = false
    (I might need this lighter later...) #Speaker:Dr.Hyde #layout:left #portrait:Dr_Hyde
    
    "I'm sorry—I.... have nothing to spare." #Speaker:Dr.Hyde #layout:left #portrait:Dr_Hyde
    
    The homeless guy smiled wryly. #Speaker:  #portrait:default 
    
    
    "I see. Then I will remain condemned and try to survive again today." #Speaker:Homeless Man  #layout: left #portrait:HomelessMan
    
    "Thank you for the short chat, young man." #Speaker:Homeless Man  #layout: left #portrait:HomelessMan
    
    Dr. Hyde left with a grim expression on his face. #Speaker:  #portrait:default 
    
    (Should I..help him earlier?) #Speaker:Dr.Hyde #layout:left #portrait:Dr_Hyde
    
    He shook her head, putting the thought in the back of his head. What he needs to do now is focus on the journey.  #Speaker:  #portrait:default 
    
    After all, if he make it, then.. everything will be worth it. #Speaker:  #portrait:default 
    
    A strong cold storm bombarded the area later on. #Speaker:  #portrait:default 
    
    Without anything to keep himself warm..the homeless guy died due to hypothermia. #Speaker:  #portrait:default 
    
    ->END

