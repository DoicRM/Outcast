INCLUDE Outcast_InDarkWood.ink

/*

    Scene info
    ----------
    
    LOCATION: Crash site of a prison transport ship, the mountain slope somewhere near the border of the Hollow
    
    OCCUPATION: None
    
    NPCS:
    - Player
    - Convoy Leader (†)

*/

=== crashsite_01 ===
You wake up among sparks and electrical surges. Your hazy vision somehow catches parts of the prison transport ship scattered around. #color:grey
You look around. Next to you lies the Guardian motionless. It seems to be the convoy leader. His limbs are twisted at odd angles. There is a very high probability that the guy did not survive this. #color:grey
-> crashsite_02

=== crashsite_02 ===
    + [Be sure and kill him.]
        Well, it would have been much easier to do it with some kind of weapon. Unfortunately, you don't have any on you. Your hands will have to suffice this time. #color:grey
        You tighten your fingers around the guard's neck and press down on him with the weight of your body. #color:grey
        "Urgh...! Krrh...!" #color:white
        The body underneath you starts to shake. #color:grey
        ++ [Continue.]
            -> crashsite_03
        ++ [Stop.]
            Yes... Leaving him alive will be a worse nightmare for him than death. #color:grey
            -> crashsite_03
    + [Leave him.]
        Yes... Leaving him alive will be a worse nightmare for him than death. #color:grey
        -> crashsite_03
    + [Search his pockets.]
        #plunder:Convoy leader
        // TODO
        -> crashsite_02
        
=== crashsite_03 ===
It's time to get out of here. Picking yourself up off the ground doesn't come easily to you.  #color:grey

-> indarkwood_01