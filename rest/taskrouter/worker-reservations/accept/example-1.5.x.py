# Download the Python helper library from twilio.com/docs/python/install
from twilio.rest import TwilioTaskRouterClient

# Your Account Sid and Auth Token from twilio.com/user/account
account_sid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
auth_token = "your_auth_token"
workspace_sid = "WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
worker_sid = "WKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
reservation_sid = 'WRXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'

client = TwilioTaskRouterClient(account_sid, auth_token)

# accept a reservation
reservation = client.workers(workspace_sid) \
    .get(worker_sid).reservations \
    .update(reservation_sid, reservation_status='accepted')
print(reservation.reservation_status)
print(reservation.worker_name)
