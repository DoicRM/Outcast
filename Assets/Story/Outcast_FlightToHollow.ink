INCLUDE Outcast_CrashSite.ink

/*

    Scene info
    ----------
    
    LOCATION: Interior of the prison transport ship, border of the Hollow
    
    OCCUPATION: None
    
    NPCS:
    - Player
    - Convoy Leader

*/

=== flighttohollow_01 ===
"Hey, you scum! Wake up! It's showtime!" #color:white
You open your sleepy eyes. Right in front of you stares a mask with two large glasses, behind which you see human eyes. At least that's what you think. The Silent Guardians are said to have nothing of the human. #color:grey

    + [What is going on?]
        "There you go, our Sleeping Beauty is up. We are approaching the Hollow." #color:white
        Your stomach twists in pain. This is due to the blows served to you by one of your tormentors. #color:grey
        "Come on, get up! We're gonna land soon!" #color:white
        -> flighttohollow_02
        
=== flighttohollow_02 ===
    + [Thanks, that's what I needed - a bit of encouragement.]
        "Junkie. Laugh while you still can. Once you hit the Hollow, there's no turning back." #color:white
        -> flighttohollow_03
    + [I'm already up, damn it!]
        "Someone here seems to be out of humour. No worries, it will only get worse after the landing." #color:white
        -> flighttohollow_03
        
=== flighttohollow_03 ===
"And just so... Get a numberator in here. We need to punch this bastard out of his serial number." #color:white
You've heard a thing or two about numbering machine and marking prisoners. The Guards here burn a unique set of numbers into their skin before exiling them. Cattle... That's what you and your ilk are to them and the government. #color:grey
"Hey, thinker, give a hand." #color:white
As you drifted your thoughts away from reality, which happens to you quite often, one of the Silent Ones brought a numberator with him. The device reminds you of a sewing machine. #color:grey
"I said: give me that hand here!" #color:white

    + [Over my dead body!]
        "You want it! Grab him." #color:white
        The guards overpower you in no time. The one with the numberator grabs your hand and puts it into the machine. A disturbing hissing sound reaches your ears... which begins to drown out the alarm. In an instant the hatch fills with red. #color:grey
        -> flighttohollow_04
    + [Let it be...]
        You see no point in resisting. The guard with the numberator grabs your hand and puts it into the machine. A disturbing hissing sound reaches your ears... which begins to drown out the alarm. In an instant the hatch fills with red. #color:grey
        -> flighttohollow_04
        
=== flighttohollow_04 ===
The guards surrounding you stand still in the blink of an eye. You take a look at your hand. It's untouched. #color:grey
"What is going on?" #color:white
In response, the hatch fills with the mechanical, slightly distorted voice of the pilot from the cockpit. #color:grey
<Code red! I repeat: code red! Take your seats! There's a missile headed our way!> #color:white
The guard in front of you puts down the numberator and sits down, poking his hateful gaze at you. #color:grey
"Don't think you've got away with it. I'll deal with you later." #color:white

    + [I would like to see this.] -> flighttohollow_05
    + [There is no need to wait.] -> flighttohollow_05
    
=== flighttohollow_05 ===
Before you have time to say anything, a mighty bang rips the world in two. Heat fills the hatch in an instant. It's a ship on fire! #color:grey
<Hold on!> #color:white
The world begins to spin, and you with it. You feel yourself accelerating and falling at ever-increasing speed with each passing second. You're screwed. #color:grey
Finally, some unknown force throws you out of your seat, and you are followed by the Silent Ones. This is the last thing you notice. The darkness dims your vision as you peer up from the ceiling.
All that is left is a void... #color:grey
#wait:5

-> crashsite_01
