import socket

def Main():
    server = ('192.168.137.128', 4000)
    s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    s.bind(('192.168.137.129',4005))
    print("Introdu un mesaj: " + data)
    message = input("-> ")

    while message !='q':
        #convert from string to bytes
        s.sendto(message.encode(), server)
        data, addr = s.recvfrom(1024)
        data = data.decode()
        print("Primit de la server: " + data)
        print("Introdu un mesaj: " + data)
        message = input("-> ")
    s.close()

if __name__=='__main__':
    Main()
