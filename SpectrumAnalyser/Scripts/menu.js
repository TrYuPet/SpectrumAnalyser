$(document).ready(new function () {
    var cls = 'selected', indx = 0, $a = $('.menu a');
    for (var i = 0; i < $a.length; i++) {
        if ($a.get(i).href == location.href) {
            $a.get(i).classList.add('selected');
        }
    }
}
);
