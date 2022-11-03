import random
x = input("Wybierz klase startową: \n Wojownik \n Mag \n Tank \n Łucznik \n ")
Lv = 0
MaxHp = None
Hp = None
M = None
MaxM = None
D = []
Gold = 0 
#  ^ Start


if x == "Wojownik":
    Klasa = "Wojownik"
    MaxHp = 120
    Hp = 120
    M = 25
    MaxM = 25
    D.append("Swing")
    D.append("Parry")
    D.append("Combo")
    D.append("Rage")
if x == "Mag":
    Klasa = "Mag"
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
if x == "Łucznik":
    Klasa = "Łucznik"
    Hp = 90
    MaxHp = 90
    M = 40
    MaxM = 40
    D.append("Shot")
    D.append("knife fencing")
    D.append("Fog Cloud")
    D.append("Head Shot")
# ^ Klasy 

 
def Stats():
    print("\n Twoje Statystyki klasy", Klasa)
    print("       Lv ", Lv)
    print("       HP ", Hp,"/",MaxHp)
    print("       Mana ", M,"/",MaxM)
    print("       Twój Deck to", D)
    print("       Złoto", Gold)
print(Stats())
#funkcja statystyk ^
while True:
    c = random.randint(1, 1)
    if c == 1:
        print("Spotkałeś Bandyte")
        BHp = 60*(1 + Lv/3)
        print(BHp)
