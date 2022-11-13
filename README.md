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
#  ^ Start


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
    D.append("Fire Pistol")
    D.append("Earth Tremor")
    D.append("Fog Cloud")
    D.append("Weak Heal")
if x == "Tank":
    Klasa = "Tank"
    Hp = 140
    MaxHp = 140
    M = 20
    MaxM = 20
    D.append("Swing")
    D.append("Shield")
    D.append("Shield Bash")
    D.append("Battle Heal")
if x == "Archer":
    Klasa = "Archer"
    Hp = 90
    MaxHp = 90
    M = 40
    MaxM = 40
    D.append("Shot")
    D.append("knife fencing")
    D.append("Fog Cloud")
    D.append("Head Shot")
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
            print(f"You are level {Lv} now")
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
    if m == "Swing (+5M)": 
        M += 5
        if M > MaxM:
            M = MaxM
        Dmg = (10 + Lv*2)*DmgMul
        BHP -= Dmg
        print(f"\n You dealt {Dmg} Damage!  ( Bandit has {BHP} HP left)  \n")
        
    if m == "Parry (-5M)":
        if M >= 5:
            M -= 5
            Eff = 1
            Eff1 = 1
            print("\n You used Parry, next enemy attack deals 50% less DMG and you reflect 50% of innate DMG\n")
        else:
            print("You dont have enought mana to use this ability")
            AS()
    if m == "Combo (-10M)":
        if M >= 10:
            M -= 10
            for i in range(3):
                c = random.randint((2+(1*Lv/2))*DmgMul, (10+(1*Lv/2))*DmgMul)
                print(f"\n You dealt {c} Damage!")
                BHP -= c
         
        
        
        

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
    
    
    
    if Eff == 1:
        SpecEff(Eff1, 0)
        Eff = 0
            

def SpecEff(n, n2):
    global SD
    global M
    global BHP
    global Dmg
    global BD
    #Parry
    if n == 1:
        SD = BD*0.5
        BD = BD*0.5
        if n2 == 1:
            SD = 0
            Eff = 0
            BD = BD
        
       
        
        


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
        sleep(1.4)
        while True:
            a = random.randint(1, 2)
            print(f"\n {D}")
            AS()
            if BHP <= 0:
                sleep(1)
                print("Bandit got defeated!")
                vc = random.randint(1, 10)
                Gold += vc
                print(f"You got {vc} Gold\n")
                Lev(50)
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
                print(f"Bandit used Stab, he dealt {BD} DMG, now you have {Hp} HP")
                if Hp <= 0:
                    sleep(1)
                    print("\n YOU DIED \n")
                    break
            if a == 2:
                Hp -= BD
                stel = random.randint(0, 2)
                Gold -= stel
                sleep(1)
                print(f"Bandit used Thievery , he dealt {BD} DMG and stole {stel} Gold, now you have {Hp} HP \n")
                if Hp <= 0:
                    sleep(1)
                    print("\n YOU DIED \n")
                    break
            if SD != 0:
                BHP -= SD
                print(f"Bandit got damaged for {SD} damage")
                SpecEff(Eff1, 1)
                if BHP <= 0:
                    sleep(1)
                    print("Bandit got defeated!")
                    vc = random.randint(1, 10)
                    Gold += vc
                    print(f"You got {vc} Gold\n")
                    Lev(50)
                    break
            sleep(1)
                
