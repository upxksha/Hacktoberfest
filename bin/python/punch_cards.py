T = int(input())

def punchcardArt(rows, cols):
    bor = ("-+"*cols)+"\n"
    car = (".|"*cols)+"\n"
    prints = rows-1
    art = (".."+bor[1::])+("."+car)+((("+"+bor)+("|"+car))*prints)+("+"+bor)
    return art
    
if __name__ == "__main__":
    for x in range(1, T+1):
        R, C = [int(a) for a in input().split()]
        art = punchcardArt(R, C)
        print(f"Case #{x}:\n{art}")
