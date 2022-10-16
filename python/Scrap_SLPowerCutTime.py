import requests
from datetime import datetime, timedelta
requests.packages.urllib3.disable_warnings()

#This is a simple script written to scrap SL powercut times according to your group.
#Since this is not sesitive information I don't think it's illegal but plase use this responsibly.

# Example use cases : 
# You can make a simple script using this to scrap time and send a whatsapp message using twillio , add alarms , setup cron jobs etc...

# My use case for this :
# I'm using this as a part of a script which I've added as a cron job in my server, which automatically scraps powercut times daily and send it to my task scheduller api (cronicle) to shut down my servers before the powercut.

# You can get the cookie and auth(Request verification code) using inspect elements (https://cebcare.ceb.lk/Incognito/OutageMap) and checking the network -> Fetch/XHR
# It is inside the request header.
# For some reason this cookie and auth doesn't expire so you only have to set it once. 
# Your electric bill account number will be on the CEB care app(You can also get your powerct group from the app) or inside any old electricity bills you recieved.

#You can use this as a standalone script or as a part of a larger script by making neccessary changes.

S_Cookie = "Cookie"

S_Auth = "Request Verification Token"

Date1 = datetime.now().strftime('%Y-%m-%d')
Date2 = datetime.now() + timedelta(days=1)

Disconnect_Time = []

def GetValues(cookie, verify_token):
    S_Headers = {
            "Content-Type":"json",
            "Cookie":cookie,
            "RequestVerificationToken" : verify_token
            }

    S_URL = f"https://cebcare.ceb.lk/Incognito/GetCalendarData?from={Date1}&to={Date2.strftime('%Y-%m-%d')}&acctNo=Your_ElectricBill_AccNo"

    response = requests.get(url=S_URL,headers=S_Headers,verify=False)

    GetTime(response.json())


def GetTime(J_Content):

    Interupts = J_Content['interruptions']
    
    for v in Interupts:
        if 'startTime' in v :
            T_Time = v['startTime'].split('Your-Powercut-Group-(ex:- .split(T))')[1].split(":")
            S_Time = T_Time[0] + ":" + T_Time[1]

            Disconnect_Time.append(S_Time) 

def RunScrapper():
    GetValues(S_Cookie,S_Auth)
    return Disconnect_Time

print(RunScrapper())