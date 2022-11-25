import random
from time import sleep
x = input("Choose starting class: \n Warrior \n Wizard \n Tank \n Archer \n ")
Lv = 0
MaxHp = None
Hp = None
M = None
MaxM = None
D = []
Gold = 5
BHP = None
BD = None
Dmg = None
Exp = 0
Exp1 = 100
Eff = 0
Eff1 = None
SD = 0
DmgMul = 1
Tura = 0
#  ^ Start
ParryTime = 0
RageTime = 0
FirePistolTime = 0
FogCloudTime = 0
ShieldTime = 0
ShieldedDMG = 0
DisarmTime = 0
WeakTime = 0
# ^ SpecjalneEfekty
if x == "Warrior":
    Klasa = "Warrior"
    MaxHp = 120
    Hp = 120
    M = 25
    MaxM = 25
    D.append("Swing (+5M)")
    D.append("Parry (-5M)")
    D.append("Combo (-10M)")
    D.append("Rage (-10M)")
if x == "Wizard":
    Klasa = "Wizard"
    Hp = 80
    MaxHp = 80
    M = 60
    MaxM = 60
    D.append("Fire Pistol (-10M)")
    D.append("Mana Restore (+25M)")
    D.append("Fog Cloud(-15M)")
    D.append("Weak Heal(-10M)")
if x == "Tank":
    Klasa = "Tank"
    Hp = 140
    MaxHp = 140
    M = 20
    MaxM = 20
    D.append("Swing (+5M)")
    D.append("Shield (+? M)")
    D.append("Shield Bash (-15M)")
    D.append("Battle Heal (-10M)")
if x == "Archer":
    Klasa = "Archer"
    Hp = 90
    MaxHp = 90
    M = 40
    MaxM = 40
    D.append("Shot (+5M)")
    D.append("Disarm (-10M)")
    D.append("Fog Cloud(-15M)")
    D.append("Lucky Shot(0M)")
# ^ Klasy 
def Lev(t):
    global Lv
    global Exp 
    global Exp1
    global MaxM
    global Hp
    global M
    global MaxHp
    Exp += t*(1 + Lv/4)
    while True:
        if Exp1 <= Exp:
            Lv += 1
            Exp -= Exp1
            print(f"You are level {Lv} now\n")
            Exp1 += 30
            MaxHp += 10
            Hp += 10
            MaxM += 5
            M += 5
        else:
            break
        
    
    
    
def Moves(m):
    global M
    global BHP
    global Dmg
    global Eff
    global Eff1
    global ParryTime
    global RageTime
    global DmgMul
    global Lv
    global FirePistolTime
    global Hp
    global FogCloudTime
    global ShieldTime
    global ShieldedDMG
    global DisarmTime
    global WeakTime
    if m == "Swing (+5M)": 
        M += 5
        if M > MaxM:
            M = MaxM
        Dmg = (10 + Lv*2)*DmgMul
        Dmg = round(Dmg, 1)
        BHP -= Dmg
        print(f"\n You dealt {Dmg} Damage!  ( Bandit has {BHP} HP left)  \n")
        
    if m == "Parry (-5M)":
        if M >= 5:
            M -= 5
            Eff = 1
            Eff1 = 1
            ParryTime = 1
            print("\n You used Parry, next enemy attack deals 50% less DMG and you reflect 50% of innate DMG\n")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Combo (-10M)":
        if M >= 10:
            M -= 10
            for i in range(3):
                a = 2+(1+(Lv/2))
                b = 9+(1+(Lv/2))
                c = random.randint(2, 9)
                c = c*(1+(Lv/3))
                c = round(c, 1)
                c = c*DmgMul
                print(f"\n You dealt {c} Damage!")
                BHP -= c
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Rage (-10M)":
        if M >= 10 and RageTime == 0:
            M -= 10
            RageTime += 3
            DmgMul += 0.7
            print("\n You used Rage, your next 2 attacks deal 70% more Dmg")
        else:
            print("You dont have enought mana to use this ability or u have Rage actived already")
            AS()    
    if m == "Fire Pistol (-10M)":
        if M >= 10:
            M -= 10
            Dmg = (10 + Lv*2)*DmgMul
            Dmg = round(Dmg, 1)
            BHP -= Dmg
            FirePistolTime = 2
            print(f"\n You dealt {Dmg} Damage and set enemy on fire for 2 rounds!  ( Bandit has {BHP} HP left)  \n")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Mana Restore (+25M)":
        M += 25
        if M > MaxM:
             M = MaxM
        print("You restored 25 Mana!")
    if m == "Weak Heal(-10M)":
        if M >= 10:
            M -= 10
            p = MaxHp * 0.15
            Hp += p
            if Hp >= MaxHp:
                Hp = MaxHp
            print(f"You healed yourself for {p} HP, now you have {Hp} HP!")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Fog Cloud(-15M)":
        if M >= 15:
            M -= 15
            FogCloudTime = 2
            print(f"You used Fog Cloud, you have 65% to dodge 2 next attacks ")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Shield (+? M)":
            ShieldTime = 1
            print("You used Shield, next enemy attack dmg deals 80% less dmg, also you get mana amount equal to half dmg blocked")
    if m == "Battle Heal (-10M)":
        if M >= 10:
            M -= 10
            p = 2 + MaxHp*0.05
            Hp += p
            if Hp >= MaxHp:
                Hp = MaxHp
            print(f"You healed yourself for {p} HP, now you have {Hp} HP!")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Shield Bash (-15M)":
        if M >= 10:
            M -= 10
            d = ShieldedDMG * 0.8
            BHP -= round(d, 1) + 5
            ShieldedDMG = 0
            print(f"You deal dmg equal to 80% of DMG blocked by your shield plus 5, you dealt {round(d, 1)  + 5} DMG, Shielded DMG reset")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Shot (+5M)":
        M += 5
        if M > MaxM:
            M = MaxM
        Dmg = (13 + Lv*2)*DmgMul
        Dmg = round(Dmg, 1)
        BHP -= Dmg
        print(f"\n You dealt {Dmg} Damage!  ( Bandit has {BHP} HP left)  \n")
        
    if m == "Disarm (-10M)":
        if M >= 10:
            M -= 10
            d = 5*(1 + Lv/2)
            DisarmTime = 1
            WeakTime = 3
            BHP -= round(d, 1)
            print(f"You disarmed your opponent, you dealt {round(d, 1)}, stunned him for 1 turn and made him weak for 2 turns")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Lucky Shot(0M)":
            Los = random.randint(1, 10)
            if Los <= 5:
                Dmg = (9 + Lv*2)*DmgMul
                BHP -= Dmg
                print(f"\nYou used regular arrow, you dealt {Dmg} Damage!  ( Bandit has {BHP} HP left)  \n")
            if Los > 5 and Los < 8:
                M += 10
                if M > MaxM:
                    M = MaxM
                DisarmTime = 1
                print(f"\n You used arrow full of energy, you regained 10 Mana and stunned enemy for 1 turn")
            if Los > 7 and Los < 10:
                FirePistolTime = 3
                Dmg = (10 + Lv*2)*DmgMul
                BHP -= round(Dmg, 1)
                print(f"You used Fire Arrow, you dealt {Dmg} DMG and burned enemy, Enemy has {BHP} HP left ")
            if Los == 10:
                Dmg = (25 + Lv*4)*DmgMul
                M += 5
                BHP -= round(Dmg, 1)
                if M > MaxM:
                    M = MaxM
                print(f"Jackpot! You hit headshot, dealt {Dmg} and regenerated 5 Mana, Enemy has {BHP} HP left")
                
                
                

        
        

def EnMoves(M, a):
    global BD
    global Hp
    global Gold
    global BHP
    global Eff
    if M == 1:
        if a == 1:
            BD = random.randint(5 + (Lv*2), 10 + (Lv*2))
        if a == 2:
            BD = 7*(1 + Lv/2) 
    
    
    if ParryTime <= 1 or FogCloudTime >= 1 or ShieldTime >= 1:
        SpecEff(0)
            

def SpecEff(n):
    global SD
    global M
    global BHP
    global Dmg
    global BD
    global ParryTime
    global ShieldedDMG
    global DisarmTime 
    #Parry
    if ParryTime == 1:
        SD += BD*0.5
        SD = round(SD, 1)
        BD = BD*0.5
        BD = round(BD, 1)
    if FogCloudTime >= 1:
        p = random.randint(1, 100)
        if p >= 36:
            BD = 0
    if ShieldTime >= 1:
        c = BD * 0.8
        ShieldedDMG += c 
        BD = BD *0.2
        BD = round(BD, 1)
        M += round(c*0.5, 1)
        if M >= MaxM:
            M = MaxM
    if DisarmTime >= 1:
        BD = 0
    if WeakTime >= 1:
        BD = round(BD*0.8, 1)
        

        
            
            
def Timere(Ded):
    global Hp
    global SD
    global M
    global BHP
    global Dmg
    global BD
    global ParryTime
    global RageTime
    global Eff1
    global DmgMul
    global FirePistolTime
    global FogCloudTime
    global ShieldTime
    global DisarmTime
    global WeakTime
    #Parry
    if ParryTime <= 1 or Ded == 1:
        ParryTime = 0
        SD = 0
        Eff1 = 0
        BD = BD
    if RageTime >= 1:
        RageTime = RageTime - 1
        if RageTime == 0 or Ded == 1:
            DmgMul -= 0.7
    if FirePistolTime >= 1:
        FirePistolTime -= 1
        minid = 5 + Lv*2
        BHP -= minid
        print(f"Enemy got burned for {minid} DMG, now he has {BHP} HP")
        if FirePistolTime <= 0 or Ded == 1:
            FirePistolTime = 0
    if FogCloudTime >= 1 or Ded == 1:
        if BD == 0:
            print("You dodged enemy attack!")
        FogCloudTime -= 1
    if ShieldTime >= 1:
        ShieldTime -= 1
        print(f"You have shielded yourself from an enemy attack, now you have {M} Mana and {Hp} HP")
    if DisarmTime >= 1:
        DisarmTime = 0
        print("Enemy is stunned!")
    if WeakTime >= 1:
        WeakTime -= 1
        if Ded == 1:
            WeakTime = 0
    Hp = round(Hp, 1)
    BHP = round(BHP, 1)




        
        


def AS():
    L = int(input("\n Choose ability from 1 to 4 "))
    L1 = D[(L - 1)]
    sleep(0.3)
    Moves(L1)
def Stats():
    print("\n Your", Klasa, "Stats")
    print("       Lv ", Lv)
    print("       HP ", Hp,"/",MaxHp)
    print("       Mana ", M,"/",MaxM)
    print("       Your Deck", D)
    print("       Gold" , Gold)
    print("       Exp", Exp,"/",Exp1)
print(Stats())
#funkcje ^
while True:
    c = random.randint(1, 1)
    sleep(1.4)
    if c == 1:
        BHP = 60*(1 + Lv/3)
        print(f"\n You run across hostile bandit!({BHP} HP)")
        #Na dole pętla walki
        sleep(0.8)
        while True:
            Timere(0)
            Tura += 1
            sleep(2.5)
            print(f"---------------------------- Turn {Tura} ---------------------------- \n ")
            a = random.randint(1, 2)
            print(f" {D}")
            AS()
            print("")
            sleep(1)
            if BHP <= 0:
                sleep(1)
                print("Bandit got defeated!")
                Timere(1)
                vc = random.randint(1, 10)
                Gold += vc
                print(f"You got {vc} Gold")
                Lev(60)
                print("You got 60 Exp\n")
                Tura = 0
                break
            if a == 1:
                EnMoves(1, 1)
                #Zwykle uderzenie
            if a == 2:
                EnMoves(1, 2)
                #zabranie golda
            if a == 1:
                Hp -= BD
                sleep(1)
                print(f"\n Bandit used Stab, he dealt {BD} DMG, now you have {Hp} HP")
                if Hp <= 0:
                    sleep(1)
                    print("\n YOU DIED \n")
                    break
            if a == 2:
                Hp -= BD
                stel = random.randint(0, 2)
                Gold -= stel
                sleep(1)
                print(f"\n Bandit used Thievery , he dealt {BD} DMG and stole {stel} Gold, now you have {Hp} HP \n")
                if Hp <= 0:
                    sleep(1)
                    print("\n YOU DIED \n")
                    break
            if SD != 0:
                BHP -= SD
                sleep(1)
                print(f"Bandit got damaged for {SD} damage")
                SpecEff(Eff1)
                if BHP <= 0:
                    sleep(1)
                    print("Bandit got defeated!")
                    Timere(1)
                    vc = random.randint(1, 10)
                    Gold += vc
                    print(f"You got {vc} Gold\n")
                    Lev(60)
                    Tura = 0
                    break
