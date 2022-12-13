const ctx = document.getElementById('myChart').getContext('2d');
const myChart = new Chart(ctx, {
    type: 'pie',
    data: {
        labels: ['1 вид', '2 вид', '3 вид', '4 вид', '5 вид'],
        datasets: [{
            label: 'Распределение заготовок по способам раскроя, шт ',
            data: [document.getElementById("X1").value, document.getElementById("X2").value,
            document.getElementById("X3").value, document.getElementById("X4").value,
            document.getElementById("X5").value],

            backgroundColor: [
                'rgba(255,0,0,0.2)',
                'rgba(250,251,100,0.2)',
                'rgba(0,255,0,0.2)',
                'rgba(0,0,255,0.2)',
                'rgba(255, 200, 97, 0.2)',

            ],
            borderColor: [
                'rgba(255,0,0,0.2)',
                'rgba(250,251,100,0.2)',
                'rgba(0,255,0,0.2)',
                'rgba(0,0,255,0.2)',
                'rgba(255, 200, 97, 0.2)', 

            ],
            borderWidth: 1
        }]
    },
    options: {
        plugins: {
            title: {
                display: true,
                text: 'Распределение заготовок по способам раскроя, шт'
            }
        }
    }
}
    );