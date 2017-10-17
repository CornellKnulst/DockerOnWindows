FROM nginx:1.13.5

ADD nginx.conf /etc/nginx/nginx.conf
ADD certificate.pem /etc/ssl/certs/certificate.pem
ADD certificate.key /etc/ssl/private/certificate.key

EXPOSE 80 443