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
                'rgba(163,221,203,0.2)',
                'rgba(232,233,161,0.2)',
                'rgba(230,181,102,0.2)',
                'rgba(229,112,126,0.2)',
                'rgba(255, 206, 86, 0.2)',

            ],
            borderColor: [
                'rgba(163,221,203,1)',
                'rgba(232,233,161,1)',
                'rgba(230,181,102,1)',
                'rgba(229,112,126,1)',
                'rgba(255, 206, 86, 1)',

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