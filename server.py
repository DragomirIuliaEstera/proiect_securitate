import socket

def Main():
   
    s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    s.bind(('192.168.1.102', 4000))

    print("Server-ul a fost pornit")
    
    while True:
             
    data, addr = s.recvfrom(1024)
    data = data.decode()
    print("Ai primit urmatorul mesaj: " + data)
    data = "Mesaj primit"
    print("Trimite: " + data)
    s.sendto(data.encode(), addr)
        
    s.close()
    
if __name__=='__main__':
    Main()