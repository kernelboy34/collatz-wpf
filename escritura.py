import pyautogui
import webbrowser as web
import time
def opciones():
    print("bienvenido al servicio de conexion")
    print("con cual de nuestras opciones guaria conectarse hoy?")
    print(""" 1.BINANCE
              2.METATRADER
              3.TRADING VIEW""")
    a=input(str("ingresa tus datos"))
    if a == "binance":
        web.open("https://accounts.binance.com/en/register-person?gclid=Cj0KCQiAj4ecBhD3ARIsAM4Q_jFq_p-iQC22GQIpMYnyUPT-sv9o8_7IKrnfGBkSYZk2-aHsLmCcu1oaAt1ZEALw_wcB&ref=531235644")
        with open('C:\\Users\\Usuario\\Desktop\\usuario\\archivosxd.txt' ) as j:
            pija=j.readlines()
            if pija == "usuario" or "contrasena":
                print(pija)
                time.sleep(19)
                pyautogui.write("iam")
            
    if a =="metatrader":
        web.open("https://admiralmarkets.sc/latam/trading-platforms/metatrader-4?utm_source=google&utm_medium=cpc&utm_campaign=BO_ES_Search_Generic&utm_content=platforms&utm_term=metatrader&gclid=Cj0KCQiAj4ecBhD3ARIsAM4Q_jEkFKGiU1haykcbPPwu8V1N5pkRhm_yjsHf-8QQVkS52g2csb_z-fgaAsdsEALw_wcB")
        with open('C:\\Users\\Usuario\\Desktop\\usuario\\archivosxd.txt' ) as j:
            pija=j.readlines()
            if pija == "usuario" or "contrasena":
                print(pija)
                time.sleep(19)
                pyautogui.write(pija)
    if a == "tradingview":
        web.open("https://es.tradingview.com")
        with open('C:\\Users\\Usuario\\Desktop\\usuario\\archivosxd.txt' ) as j:
            pija=j.readlines()
            if pija == "usuario" or "contrasena":
                print(pija)
                time.sleep(19)
                pyautogui.write(pija)
    else:
        print("novalido joven")
opciones()
