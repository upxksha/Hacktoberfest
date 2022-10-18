from email.message import EmailMessage
import ssl
import smtplib

email_sender = "Senders-Email"
email_password = "Senders-Email-App-Password" #If you don't know how to create an app password, please watch a youtube video it's a 2min process.
email_receiver = "Recievers-Email"

def SendMail(Email_Body):
    subject = "This is my email subject !"
    body = Email_Body

    em  = EmailMessage()
    em['From'] = email_sender
    em['To'] = email_receiver
    em['Subject'] = subject
    em.set_content(body)

    context = ssl.create_default_context()

    with smtplib.SMTP_SSL('smtp.gmail.com', 465, context=context) as SMTP:
        SMTP.login(email_sender,email_password)
        SMTP.sendmail(email_sender,email_receiver,em.as_string())


SendMail("This is my email body !")