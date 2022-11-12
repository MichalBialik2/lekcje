import random
x = input("Choose starting class: \n Warrior \n Wizard \n Tank \n Archer \n ")
Lv = 0
MaxHp = None
Hp = None
M = None
MaxM = None
D = []
Gold = 0 
BHP = None
BD = None
Dmg = None
#  ^ Start


if x == "Warrior":
    Klasa = "Warrior"
    MaxHp = 120
    Hp = 120
    M = 25
    MaxM = 25
    D.append("Swing")
    D.append("Parry")
    D.append("Combo")
    D.append("Rage")
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
def Moves(m):
    global M
    global BHP
    global Dmg
    if m == "Swing": 
        M += 5
        if M > MaxM:
            M = MaxM
    Dmg = (10 + Lv*2)
    BHP -= Dmg
    print(f"You dealt {Dmg} Damage!")


 
def Stats():
    print("\n Your", Klasa, "Stats")
    print("       Lv ", Lv)
    print("       HP ", Hp,"/",MaxHp)
    print("       Mana ", M,"/",MaxM)
    print("       Your Deck", D)
    print("       Gold" , Gold)
print(Stats())
#funkcja statystyk ^
while True:
    c = random.randint(1, 1)
    if c == 1:
        print("You run across hostile bandit!")
        BHP = 60*(1 + Lv/3)
        #Na dole pętla walki
        while True:
            a = random.randint(1, 2)
            if a == 1:
                BD = random.randint(5 + (Lv*2), 10 + (Lv*2))
                #Zwykle uderzenie
            if a == 2:
                BD = 7*(1 + Lv/4) 
                #zabranie golda
            print(D)
            L = int(input("Choose ability from 1 to 4 "))
            L1 = D[(L - 1)]
            Moves(L1)
