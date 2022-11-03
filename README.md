import random
x = input("Wybierz klase startową: \n Wojownik \n Mag \n Tank \n Łucznik ")
Lv = 0
MaxHp = None
Hp = None
M = None
D = []
if x == "Wojownik":
    MaxHp = 120
    Hp = 120
    Mana = 25
    D.append("Swing")
    D.append("Parry")
    D.append("Combo")
    D.append("Rage")
if x == "Mag":
    Hp = 80
    MaxHp = 80
    Mana = 60
    D.append("Fire Pistol")
    D.append("Earth Tremor")
    D.append("Fog Cloud")
    D.append("Weak Heal")
if x == "Tank":
    Hp = 140
    MaxHp = 140
    Mana = 20
    D.append("Swing")
    D.append("Shield")
    D.append("Shield Bash")
    D.append("Battle Heal")
if x == "Łucznik":
    Hp = 90
    Mana = 40
    D.append("Shot")
    D.append("knife fencing")
    D.append("Fog Cloud")
    D.append("Head Shot")
 
def Stats():
    print("Lv =", a)
    print("HP =", b)
    print("Mana =", Hp)
