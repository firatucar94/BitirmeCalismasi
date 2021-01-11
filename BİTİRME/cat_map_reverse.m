function [  ] = cat_map_reverse( p,q )
im=imread('lena3.jpg');
 N=size(im,1);
 X=zeros(size(im));


for i=1:N
    for j=1:N
         newi=mod(((p*q+1)*(i-1) + (-p)*(j-1)),N)+1;
        newj=mod(((-q)*(i-1) + (j-1)),N)+1;
        
        
%         
%         X(newi,newj,:)=im(i,j,:);
            X(newi,newj,1)=im(i,j,1);
            X(newi,newj,2)=im(i,j,2);
            X(newi,newj,3)=im(i,j,3);
        
    end
end
 X=uint8(X);
imtool(X);

end
