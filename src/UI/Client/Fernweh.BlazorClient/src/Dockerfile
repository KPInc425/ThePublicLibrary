FROM nginx:alpine as final
EXPOSE 5007/tcp
WORKDIR /usr/share/nginx/html
ADD "https://www.random.org/cgi-bin/randbyte?nbytes=10&format=h" skipcache
COPY ./src/Fernweh.BlazorClient/src/bin/Release/net7.0/publish/wwwroot/ /etc/nginx/html/
#COPY --from=publish /app/publish/wwwroot/ /etc/nginx/html/
WORKDIR /
COPY ./src/Fernweh.BlazorClient/src/ngix.conf /etc/nginx/nginx.conf
COPY ./src/Fernweh.BlazorClient/src/entrypoint.sh .
RUN chmod +x ./entrypoint.sh
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
CMD ["nginx", "-g", "daemon off;"]
 
#CMD /bin/bash ./entrypoint.sh