let maxhp=1200, z=100, i=0, d=50;
for (; z>0 && z>=(2*maxhp/3); z-=d, i++) {
        console.log(z);
        document.write('<h4>Рубишь в капусту</h4>');
};
for (; z>0 && z>=(maxhp/3); z-=d, i++) {
        console.log(z);
        document.write('<h4>Ебашишь в кашу</h4>');
};
for (; z>0 && z<(maxhp/3); z-=d, i++) {
        console.log(z);
        document.write('<h4>Выжимаешь последние капельки!</h4>');
};
if (z>0) {
        document.write('<h4>Враг сбежал!</h4>');
}
else {
        document.write('<h4>Враг повержен за ', i, ' ударов!</h4>');
};